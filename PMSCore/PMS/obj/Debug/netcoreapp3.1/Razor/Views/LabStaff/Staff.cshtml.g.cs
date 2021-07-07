#pragma checksum "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\LabStaff\Staff.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ae83221e0a3b4a31433fbcdb62285108bca8773"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LabStaff_Staff), @"mvc.1.0.view", @"/Views/LabStaff/Staff.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ae83221e0a3b4a31433fbcdb62285108bca8773", @"/Views/LabStaff/Staff.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93ce4f72f6dfce34342b9241fe3c069991c39bf1", @"/Views/_ViewImports.cshtml")]
    public class Views_LabStaff_Staff : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/Script/Local/Pathology/Staff.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row-fluid"">
    <div class=""span12 grider"">
        <div class=""widget widget-simple"">
            <div class=""widget-header"">
                <h4><i class=""fa fa-list glyph""></i> Staff List</h4>
                <div class=""widget-tool""><a class=""btn btn-green btn-small btn-glyph"" onclick=""AddStaff()""><i class=""fa fa-plus""></i> Add Staff</a></div>
            </div>
            <div class=""widget-content"">
                <div class=""widget-body"">
                    <div class=""row-fluid"">
                        <div class=""span12"">
                            <fieldset>
                                <ul class=""form-list list-bordered dotted"">
                                    <li class=""control-group"" id=""tblMasterList"">
                                        <div class=""widget widget-simple widget-table"">
                                            <table id=""exampleDTC"" class=""table table-striped table-content table-condensed boo-table table-hover bg-green-light"">
                      ");
            WriteLiteral(@"                          <caption class=""caption-m""><span>Staff List</span></caption>
                                                <thead>
                                                    <tr>
                                                        <th scope=""col"">Doctore Name<span class=""column-sorter""></span></th>
                                                        <th scope=""col"">Gender<span class=""column-sorter""></span></th>
                                                        <th scope=""col"">Mobile No.<span class=""column-sorter""></span></th>
                                                        <th scope=""col"">Specialization<span class=""column-sorter""></span></th>
                                                        <th scope=""col"">Address<span class=""column-sorter""></span></th>
                                                        <th scope=""col"">Action<span class=""column-sorter""></span></th>
                                                    </tr>
                                 ");
            WriteLiteral("               </thead>\n                                                <tbody>\n");
#nullable restore
#line 30 "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\LabStaff\Staff.cshtml"
                                                     if (Model.DoctorList.Count > 0)
                                                    {
                                                        foreach (var item in Model.DoctorList)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 35 "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\LabStaff\Staff.cshtml"
                                           Write(item.DoctorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 36 "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\LabStaff\Staff.cshtml"
                                           Write(item.GenderText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 37 "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\LabStaff\Staff.cshtml"
                                           Write(item.MobileNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 38 "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\LabStaff\Staff.cshtml"
                                           Write(item.SpecializationText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 39 "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\LabStaff\Staff.cshtml"
                                           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td><a title=\"Edit\" data-toggle=\"tooltip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2903, "\"", 2947, 3);
            WriteAttributeValue("", 2913, "DoctorOperations(", 2913, 17, true);
#nullable restore
#line 40 "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\LabStaff\Staff.cshtml"
WriteAttributeValue("", 2930, item.RowId, 2930, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2941, ",\'E\');", 2941, 6, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-pencil\"></i></a> | <a title=\"Delete\" data-toggle=\"tooltip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3023, "\"", 3073, 3);
            WriteAttributeValue("", 3033, "DeleteDoctorOperations(", 3033, 23, true);
#nullable restore
#line 40 "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\LabStaff\Staff.cshtml"
WriteAttributeValue("", 3056, item.RowId, 3056, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3067, ",\'D\');", 3067, 6, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i></a></td>\n                                        </tr> ");
#nullable restore
#line 41 "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\LabStaff\Staff.cshtml"
                                              }
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr><td colspan=\"6\"> Record Not Found ...</td></tr>\n");
#nullable restore
#line 46 "D:\Projects\PMS_MVC_OLD\PMSCore\PMS\Views\LabStaff\Staff.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </tbody>
                                            </table>
                                        </div>
                                    </li>
                                    <!-- // form item -->
                                    <li>
                                        <div id=""AddStaff"" class=""modal hide fadee"" data-keyboard=""false"" data-width=""90%"" data-backdrop=""static"">
                                        </div>
                                    </li>
                                </ul>
                            </fieldset>
                            <!-- // fieldset Input -->
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- // Widget -->
    </div>
    <!-- // Column -->
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ae83221e0a3b4a31433fbcdb62285108bca877310514", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
