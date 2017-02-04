#pragma checksum "TestFiles/Input/ModelExpressionTagHelper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faaab08eebb321aea098bd40df018e89cd247b6f"
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    public class Generated_ModelExpressionTagHelper : Microsoft.AspNetCore.Mvc.Razor.RazorPage<DateTime>
    {
        #line hidden
        #pragma warning disable 0414
        private string __tagHelperStringValueBuffer = null;
        #pragma warning restore 0414
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.InputTestTagHelper __Microsoft_AspNetCore_Mvc_Razor_InputTestTagHelper = null;
        private global::Microsoft.AspNetCore.Mvc.Razor.DictionaryPrefixTestTagHelper __Microsoft_AspNetCore_Mvc_Razor_DictionaryPrefixTestTagHelper = null;
        #pragma warning disable 1998
        public async override Task ExecuteAsync()
        {
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(244, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input-test", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "40dd6f55e92549a7bb65557f286ba4ae", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_InputTestTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.InputTestTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_InputTestTagHelper);
#line 6 "TestFiles/Input/ModelExpressionTagHelper.cshtml"
__Microsoft_AspNetCore_Mvc_Razor_InputTestTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Now);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_Razor_InputTestTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginContext(246, 24, false);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(270, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input-test", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fefc7053a7b2407c9466363b4391d46e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_InputTestTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.InputTestTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_InputTestTagHelper);
#line 7 "TestFiles/Input/ModelExpressionTagHelper.cshtml"
__Microsoft_AspNetCore_Mvc_Razor_InputTestTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_Razor_InputTestTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginContext(272, 27, false);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(299, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe8376ddd7f24e02955e7fe31c4b484a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_DictionaryPrefixTestTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.DictionaryPrefixTestTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_DictionaryPrefixTestTagHelper);
            if (__Microsoft_AspNetCore_Mvc_Razor_DictionaryPrefixTestTagHelper.PrefixValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("prefix-test", "Microsoft.AspNetCore.Mvc.Razor.DictionaryPrefixTestTagHelper", "PrefixValues"));
            }
#line 9 "TestFiles/Input/ModelExpressionTagHelper.cshtml"
__Microsoft_AspNetCore_Mvc_Razor_DictionaryPrefixTestTagHelper.PrefixValues["test"] = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("prefix-test", __Microsoft_AspNetCore_Mvc_Razor_DictionaryPrefixTestTagHelper.PrefixValues["test"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginContext(303, 33, false);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(336, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8588738ef8e4a52b9ca39605d086915", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_DictionaryPrefixTestTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.DictionaryPrefixTestTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_DictionaryPrefixTestTagHelper);
            if (__Microsoft_AspNetCore_Mvc_Razor_DictionaryPrefixTestTagHelper.PrefixValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("prefix-hour", "Microsoft.AspNetCore.Mvc.Razor.DictionaryPrefixTestTagHelper", "PrefixValues"));
            }
#line 10 "TestFiles/Input/ModelExpressionTagHelper.cshtml"
__Microsoft_AspNetCore_Mvc_Razor_DictionaryPrefixTestTagHelper.PrefixValues["hour"] = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Hour);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("prefix-hour", __Microsoft_AspNetCore_Mvc_Razor_DictionaryPrefixTestTagHelper.PrefixValues["hour"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 10 "TestFiles/Input/ModelExpressionTagHelper.cshtml"
__Microsoft_AspNetCore_Mvc_Razor_DictionaryPrefixTestTagHelper.PrefixValues["minute"] = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Minute);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("prefix-minute", __Microsoft_AspNetCore_Mvc_Razor_DictionaryPrefixTestTagHelper.PrefixValues["minute"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginContext(338, 55, false);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
    }
}
