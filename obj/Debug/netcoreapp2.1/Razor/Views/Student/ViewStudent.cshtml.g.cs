#pragma checksum "C:\Users\Abhishek Bhardwaj\source\repos\DuckTaleSolutionTask\Views\Student\ViewStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e7d8bf204c2ee0460fa2a65e1984b759597ed40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_ViewStudent), @"mvc.1.0.view", @"/Views/Student/ViewStudent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/ViewStudent.cshtml", typeof(AspNetCore.Views_Student_ViewStudent))]
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
#line 1 "C:\Users\Abhishek Bhardwaj\source\repos\DuckTaleSolutionTask\Views\_ViewImports.cshtml"
using DuckTaleSolutionTask;

#line default
#line hidden
#line 2 "C:\Users\Abhishek Bhardwaj\source\repos\DuckTaleSolutionTask\Views\_ViewImports.cshtml"
using DuckTaleSolutionTask.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e7d8bf204c2ee0460fa2a65e1984b759597ed40", @"/Views/Student/ViewStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fedaba77da412f9ef9e25a4857cd2b5e51ecda50", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_ViewStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/common.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("StudentDetailForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UpdateStudentDetailForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Abhishek Bhardwaj\source\repos\DuckTaleSolutionTask\Views\Student\ViewStudent.cshtml"
  
    ViewBag.Title = "Students Detail";

#line default
#line hidden
            BeginContext(49, 377, true);
            WriteLiteral(@"
    <style>
    td.details-control { background: url('https://datatables.net/examples/resources/details_open.png') no-repeat center center; cursor: pointer; }

    tr.shown td.details-control { background: url('https://datatables.net/examples/resources/details_close.png') no-repeat center center; }
    
    .subtable{
        max-width:200px;
    }
    </style>

");
            EndContext();
            BeginContext(426, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5caaa98f67fe4af4875a569578d63098", async() => {
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
            EndContext();
            BeginContext(464, 1528, true);
            WriteLiteral(@"
<div class=""row container"">
    <div class=""col-sm-12 text-center"">
        <h1>Student Management</h1> <button id=""add-student-btn-id"" class="" btn btn-primary text-right add-student-btn"" style=""float:right"" data-toggle=""modal"" data-target=""#StudentCreateFormId"">Add Student</button>
    </div>


    <div class=""col-sm-12"">
        <table class=""table table-bordered"" id=""StudentTableId"">
            <thead>
                <tr>
                    <th width=""5%""></th>
                    <th width=""5%"">Id</th>
                    <th width=""8%"">First Name</th>
                    <th width=""8%"">Last Name</th>
                    <th width=""8%"">Class</th>
                    <th width=""20%"">Subject</th>
                    <th width=""15%"">Marks</th>
                    <th width=""10%"">Actions</th>
                </tr>
            </thead>
        </table>
    </div>
</div>

<div id=""StudentCreateFormId"" class=""modal "">
    <div class=""modal-dialog modal-lg"" role=""document"">
        ");
            WriteLiteral(@"<div class=""modal-content"">
            <div class=""modal-header"">

                <h4 class=""modal-title custom_align"" id=""Heading"">
                    Add Student
                </h4>
                <button type=""button"" class=""close"" data-dismiss=""modal""
                        aria-hidden=""true"">
                    <span class=""glyphicon glyphicon-remove"" aria-hidden=""true""></span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(1992, 3825, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8df96b5f3570427888f6e125d62b6dd9", async() => {
                BeginContext(2057, 3753, true);
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""form-group"">
                                <label class=""control-label"">First Name</label>
                                <div>
                                    <input type=""text"" maxlength=""30"" onfocus=""OnFocusRemoveValidation(this)"" id=""first-name-id""  class=""form-control  required"" name=""first-name"" value="""">
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""form-group"">
                                <label class=""control-label"">Last Name</label>
                                <div>
                                    <input type=""text"" maxlength=""30"" onfocus=""OnFocusRemoveValidation(this)"" id=""last-name-id"" class=""form-control  required"" name=""last-name"" value="""">
                                </div>
               ");
                WriteLiteral(@"             </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""form-group"">
                                <label class=""control-label"">Class</label>
                                <div>
                                    <input type=""text"" maxlength=""30"" onfocus=""OnFocusRemoveValidation(this)"" id=""class-id"" class=""form-control  required"" name=""class"" value="""">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""subject-container"">
                        <div class=""row"">
                            <h4 class=""col-sm-10"">Subjects</h4><div class=""col-sm-2 text-center""> <span class=""btn btn-default"" onclick=""cloneSubjectElement(undefined,AddModalCode)"">+</span></div>
                        </div>
                        <div class=""row subjects"" id=""add-subject-id"">
                            <div class=""r");
                WriteLiteral(@"ow subject"">
                                <div class=""col-sm-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Subject Name</label>
                                        <div>
                                            <input type=""text"" maxlength=""30"" placeholder=""Enter name of the subject.."" onfocus=""OnFocusRemoveValidation(this)"" class=""form-control  required"" name=""subject-name"" value="""">
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-sm-4"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Marks</label>
                                        <div>
                                            <input type=""number"" placeholder=""Enter marks scored..""  onfocus=""OnFocusRemoveValidation(this)"" class=""for");
                WriteLiteral(@"m-control  required"" onchange=""handleChange(this);"" name=""marks"" value="""">
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-sm-2""><span  class=""btn btn-default closebtn"" onclick=""removeSubjectElement(this)"" style=""float:right;"">x</span></div>
                            </div>
                            <div class=""col-sm-12 add-subject-message"">
                                <p>*Please add atleast on subject to continue.</p>
                            </div>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5817, 1146, true);
            WriteLiteral(@"
            </div>

            <div class=""modal-footer "">
                <button type=""button"" class=""btn btn-success"" onclick=""AddStudent()""><span class=""glyphicon glyphicon-ok-sign""></span> Add </button>
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal""><span class=""glyphicon glyphicon-remove""></span> Cancel </button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div><!-- /.modal -->

<div id=""UpdateStudentFormId"" class=""modal "">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">

                <h4 class=""modal-title custom_align"" id=""Heading"">
                    Update Student

                    <button type=""button"" class=""close"" data-dismiss=""modal"" style=""float:right;""
                            aria-hidden=""true"">
                        <span class=""glyphicon glyphicon-remove"" aria-hidden=""true""></span>
        ");
            WriteLiteral("            </button>\r\n                </h4>\r\n\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                ");
            EndContext();
            BeginContext(6963, 2337, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c179aa835604d809b97ed009e281c83", async() => {
                BeginContext(7034, 2259, true);
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""form-group"">
                                <label class=""control-label"">First Name</label>
                                <div>
                                    <input type=""text"" onfocus=""OnFocusRemoveValidation(this)"" id=""update-first-name-id"" class=""form-control  required"" name=""first-name"" value="""">
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""form-group"">
                                <label class=""control-label"">Last Name</label>
                                <div>
                                    <input type=""text"" onfocus=""OnFocusRemoveValidation(this)"" id=""update-last-name-id"" class=""form-control  required"" name=""last-name"" value="""">
                                </div>
                            </di");
                WriteLiteral(@"v>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""form-group"">
                                <label class=""control-label"">Class</label>
                                <div>
                                    <input type=""text"" onfocus=""OnFocusRemoveValidation(this)"" id=""update-class-id"" class=""form-control  required"" name=""class"" value="""">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""subject-container"">
                        <div class=""row"">
                            <h4 class=""col-sm-10"">Subjects</h4><div class=""col-sm-2 text-center""> <span class=""btn btn-default"" onclick=""cloneSubjectElement(undefined,UpdateModalCode)"">+</span></div>
                        </div>
                        <div id=""update-subject-id"" class=""row subjects"">

                            <div class=""col-sm-12 add-subj");
                WriteLiteral("ect-message\">\r\n                                <p>*Please add atleast on subject to continue.</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9300, 2802, true);
            WriteLiteral(@"
            </div>

            <div class=""modal-footer "">
                <button type=""button"" class=""btn btn-success"" id=""updateStudent"" onclick=""UpdateStudent()"" disabled><span class=""glyphicon glyphicon-ok-sign""></span> Update </button>
                <button type=""button"" class=""btn btn-default"" onclick=""ClearUpdateModalControl()"" data-dismiss=""modal""><span class=""glyphicon glyphicon-remove""></span> Cancel </button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div><!-- /.modal -->

<div id=""StudentDetailModalId"" class=""modal "">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">

                <h4 class=""modal-title custom_align"" id=""Heading"">
                    Student Detail
                </h4>
                <button type=""button"" class=""close"" data-dismiss=""modal""
                        aria-hidden=""true"">
                    <span class=""glyph");
            WriteLiteral(@"icon glyphicon-remove"" aria-hidden=""true""></span>
                </button>
            </div>
            <div class=""modal-body "">
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <div class=""form-group row"">
                            <div class=""col-sm-3"">
                                <label class=""control-label "" for=""student-name-id"">Name</label>
                            </div>
                            <label class=""col-sm-1"">:</label>

                            <div class=""col-sm-8"">
                                <span class=""form-control-static"" id=""student-name-id"">Abhishek Bhardwaj</span>
                            </div>
                        </div>
                    </div>

                    <div class=""col-sm-6"">
                        <div class=""form-group row"">
                            <div class=""col-sm-3"">
                                <label class=""control-label col-sm-3"" for=""student-class-i");
            WriteLiteral(@"d"">Class </label>
                            </div>
                            <lable class=""col-sm-1"">:</lable>
                            <div class=""col-sm-8"">
                                <span class=""form-control-static"" id=""student-class-id"">Std 4</span>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-sm-12"">
                        <table class=""table table-condensed table-striped"" id=""student-subject-id"" style=""width:100%"">
                            <thead>
                                <tr><th>No.</th><th>Subject</th><th>Marks</th></tr>
                            </thead>
");
            EndContext();
            BeginContext(12447, 445, true);
            WriteLiteral(@"                        </table>
                    </div>

                </div>
            </div>

            <div class=""modal-footer "">

                <button type=""button"" class=""btn btn-default"" onclick=""ClearUpdateModalControl()"" data-dismiss=""modal""><span class=""glyphicon glyphicon-remove""></span> Close </button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div>


");
            EndContext();
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