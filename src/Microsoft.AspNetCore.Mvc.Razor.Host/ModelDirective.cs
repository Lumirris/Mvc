﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Razor.Evolution;
using Microsoft.AspNetCore.Razor.Evolution.Intermediate;

namespace Microsoft.AspNetCore.Mvc.Razor.Host
{
    public static class ModelDirective
    {
        public static readonly DirectiveDescriptor Directive = DirectiveDescriptorBuilder.Create("model").AddType().Build();

        public static IRazorEngineBuilder Register(IRazorEngineBuilder builder)
        {
            builder.AddDirective(Directive);
            builder.Features.Add(new Pass());
            return builder;
        }

        public static string GetModelType(DocumentIRNode irDocument)
        {
            Visitor visitor;
            return GetModelType(irDocument, out visitor);
        }

        private static string GetModelType(DocumentIRNode irDocument, out Visitor visitor)
        {
            visitor = new Visitor();
            visitor.Visit(irDocument);

            string modelType;
            if (visitor.Directives.Count == 1)
            {
                modelType = visitor.Directives.Last().Tokens.First().Content;
            }
            else
            {
                if (irDocument.DocumentKind == RazorPageDocumentClassifier.DocumentKind)
                {
                    modelType = visitor.Class.Name;
                }
                else
                {
                    modelType = "dynamic";
                }
            }

            return modelType;
        }

        private class Pass : IRazorIRPass
        {
            public RazorEngine Engine { get; set; }

            // Runs after the @inherits directive
            public int Order => RazorIRPass.DefaultDirectiveClassifierOrder + 5;

            public DocumentIRNode Execute(RazorCodeDocument codeDocument, DocumentIRNode irDocument)
            {
                Visitor visitor;
                var modelType = GetModelType(irDocument, out visitor);

                visitor.Class.BaseType = visitor.Class.BaseType.Replace("<TModel>", "<" + modelType + ">");

                return irDocument;
            }
        }

        private class Visitor : RazorIRNodeWalker
        {
            public ClassDeclarationIRNode Class { get; private set; }

            public IList<DirectiveIRNode> Directives { get; } = new List<DirectiveIRNode>();

            public override void VisitClass(ClassDeclarationIRNode node)
            {
                if (Class == null)
                {
                    Class = node;
                }

                base.VisitClass(node);
            }

            public override void VisitDirective(DirectiveIRNode node)
            {
                if (node.Descriptor == Directive)
                {
                    Directives.Add(node);
                }
            }
        }
    }
}
