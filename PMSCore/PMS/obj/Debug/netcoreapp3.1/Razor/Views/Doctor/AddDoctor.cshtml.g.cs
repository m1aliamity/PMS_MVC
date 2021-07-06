#pragma checksum "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\Doctor\AddDoctor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5cef40df3047b05236b506dd3744fcb91957fa6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_AddDoctor), @"mvc.1.0.view", @"/Views/Doctor/AddDoctor.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\_ViewImports.cshtml"
using PMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\_ViewImports.cshtml"
using PMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5cef40df3047b05236b506dd3744fcb91957fa6", @"/Views/Doctor/AddDoctor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93ce4f72f6dfce34342b9241fe3c069991c39bf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_AddDoctor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Pathology.DoctorModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("itemForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("span12 form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/Script/Local/Pathology/Doctor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""modal-header"">
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true""><i class=""fa fa-close""></i></button>
        <h4>Add Doctor</h4>
    </div>
    <div class=""modal-body"">
        <div class=""row-fluid"">
            <div class=""span12 grider"">
                <div class=""widget well well-nice"">
                    <div class=""widget-header"">
                        <h4><i class=""fa fa-list""></i>Add Doctor <small></small></h4>
                    </div>
                    <div class=""widget-content"">
                        <div class=""widget-body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5cef40df3047b05236b506dd3744fcb91957fa65105", async() => {
                WriteLiteral(@"
                                <div class=""row-fluid"">
                                    <div class=""span12"">
                                        <fieldset>
                                            <ul class=""form-list label-left list-bordered dotted"">
                                                <li class=""control-group"">
                                                    <div class=""span6"">
                                                        <label for=""DoctorName"" class=""control-label"">Name: <span class=""required"">*</span></label>
                                                        <div class=""controls"">
                                                            <input id=""txtDoctorName"" class=""input-block-level"" type=""text"" data-error=""Please Enter Name."" required />
                                                        </div>
                                                    </div>
                                                    <div class=""span6"">
           ");
                WriteLiteral(@"                                             <label for=""GenderName"" class=""control-label"">Gender: <span class=""required"">*</span></label>
                                                        <div class=""controls"">
                                                            ");
#nullable restore
#line 30 "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\Doctor\AddDoctor.cshtml"
                                                       Write(Html.DropDownListFor(m => m.Gender, new SelectList(Model.GenderList, "Value", "Text"), "--Select--", new { @Class = "input-block-level" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                        </div>
                                                    </div>
                                                </li>
                                                <!-- // form item -->

                                                <li class=""control-group"">
                                                    <div class=""span6"">
                                                        <label for=""MobileNoAlias"" class=""control-label"">Mobile No.: <span class=""required"">*</span></label>
                                                        <div class=""controls"">
                                                            <input id=""txtMobileNo"" class=""input-block-level"" type=""text""  data-error=""Please Enter Mobile No."" required/>
                                                        </div>
                                                    </div>
                                                    <div class=""span6"">
              ");
                WriteLiteral(@"                                          <label for=""EmailIdAlias"" class=""control-label"">Email Id:</label>
                                                        <div class=""controls"">
                                                            <input id=""txtEmail"" class=""input-block-level"" type=""text"" />
                                                        </div>
                                                    </div>
                                                </li>
                                                <!-- // form item -->
                                                <li class=""control-group"">
                                                    <div class=""span6"">
                                                        <label for=""AddressAlias"" class=""control-label"">Address: <span class=""required"">*</span></label>
                                                        <div class=""controls"">
                                                            <input id=""txtAddre");
                WriteLiteral(@"ss"" class=""input-block-level"" type=""text"" />
                                                        </div>
                                                    </div>
                                                    <div class=""span6"">
                                                        <label for=""SpecializationAlias"" class=""control-label"">Specialization:<span class=""required"">*</span></label>
                                                        <div class=""controls"">
                                                            ");
#nullable restore
#line 61 "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\Doctor\AddDoctor.cshtml"
                                                       Write(Html.DropDownListFor(m => m.Specialization, new SelectList(Model.SpecializationList, "Value", "Text"), "--Select--", new { @Class = "input-block-level" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                        </div>
                                                    </div>
                                                </li>
                                                <!-- // form item -->
                                                <li class=""control-group"">
                                                    <div class=""controls"" style=""text-align:center;"">
                                                        <button type=""button"" id=""btnCreate"" title=""Save"" data-toggle=""tooltip"" OnClick=""DoctorOperations(0,'I')"" class=""btn btn-blue""><i class=""fa fa-save""></i> Save</button>
                                                        <button type=""button"" id=""btnUpdate"" title=""Update"" data-toggle=""tooltip"" OnClick=""DoctorOperations(0,'U')"" class=""btn btn-blue"" disabled><i class=""fa fa-edit""></i> Update</button>
                                                    </div>
                                                </li>
               ");
                WriteLiteral(@"                             </ul>
                                        </fieldset>
                                        <!-- // fieldset Input -->
                                        <div class=""form-actions"">

                                        </div>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <!-- // Widget -->\r\n            </div>\r\n            <!-- // Column -->\r\n        </div>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5cef40df3047b05236b506dd3744fcb91957fa613098", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Pathology.DoctorModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
