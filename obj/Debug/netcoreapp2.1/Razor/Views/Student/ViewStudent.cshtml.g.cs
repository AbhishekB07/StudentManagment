#pragma checksum "F:\Application\GitCloned\StudentManagment-master\Views\Student\ViewStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5767d85497f60d92ee56b3c9e78f5056d51e1607"
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
#line 1 "F:\Application\GitCloned\StudentManagment-master\Views\_ViewImports.cshtml"
using DuckTaleSolutionTask;

#line default
#line hidden
#line 2 "F:\Application\GitCloned\StudentManagment-master\Views\_ViewImports.cshtml"
using DuckTaleSolutionTask.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5767d85497f60d92ee56b3c9e78f5056d51e1607", @"/Views/Student/ViewStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bdbc46e645fa199f2690ced1468502cb687a188", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_ViewStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("StudentDetailForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UpdateStudentDetailForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "F:\Application\GitCloned\StudentManagment-master\Views\Student\ViewStudent.cshtml"
  
    ViewBag.Title = "Students Detail";

#line default
#line hidden
            BeginContext(45, 1494, true);
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
        <div class=""modal-cont");
            WriteLiteral(@"ent"">
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
            BeginContext(1539, 3769, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8a198a4e6ad4cf29c9f0a71285bc14d", async() => {
                BeginContext(1604, 3697, true);
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
                            </d");
                WriteLiteral(@"iv>
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
                            <div class=""row subject"">
                   ");
                WriteLiteral(@"             <div class=""col-sm-6"">
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
                                            <input type=""number"" placeholder=""Enter marks scored..""  onfocus=""OnFocusRemoveValidation(this)"" class=""form-control  required"" onchange=""handleChange(t");
                WriteLiteral(@"his);"" name=""marks"" value="""">
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5308, 1119, true);
            WriteLiteral(@"
            </div>

            <div class=""modal-footer "">
                <button type=""button"" class=""btn btn-success"" onclick=""addStudent()""><span class=""glyphicon glyphicon-ok-sign""></span> Add </button>
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
                    </button>
");
            WriteLiteral("                </h4>\n\n            </div>\n            <div class=\"modal-body\">\n                ");
            EndContext();
            BeginContext(6427, 2299, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d775cd0bced74b4c8f1bc17f38654e35", async() => {
                BeginContext(6498, 2221, true);
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
                            </div>
             ");
                WriteLiteral(@"           </div>
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

                            <div class=""col-sm-12 add-subject-message"">
                   ");
                WriteLiteral("             <p>*Please add atleast on subject to continue.</p>\n                            </div>\n                        </div>\n                    </div>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8726, 2744, true);
            WriteLiteral(@"
            </div>

            <div class=""modal-footer "">
                <button type=""button"" class=""btn btn-success"" id=""updateStudent"" onclick=""updateStudent()"" disabled><span class=""glyphicon glyphicon-ok-sign""></span> Update </button>
                <button type=""button"" class=""btn btn-default"" onclick=""clearUpdateModalControl()"" data-dismiss=""modal""><span class=""glyphicon glyphicon-remove""></span> Cancel </button>
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
                    <span class=""glyphicon glyphicon-remove");
            WriteLiteral(@""" aria-hidden=""true""></span>
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
                                <label class=""control-label col-sm-3"" for=""student-class-id"">Class </label>
                        ");
            WriteLiteral(@"    </div>
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
            BeginContext(11808, 430, true);
            WriteLiteral(@"                        </table>
                    </div>

                </div>
            </div>

            <div class=""modal-footer "">

                <button type=""button"" class=""btn btn-default"" onclick=""clearUpdateModalControl()"" data-dismiss=""modal""><span class=""glyphicon glyphicon-remove""></span> Close </button>
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
