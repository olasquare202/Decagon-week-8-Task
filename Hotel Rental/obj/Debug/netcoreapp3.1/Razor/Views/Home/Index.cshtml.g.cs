#pragma checksum "C:\Users\hp\source\repos\Hotel_Rental\Hotel Rental\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bd069e4739c826424dad66086cade00a2a2d7a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\hp\source\repos\Hotel_Rental\Hotel Rental\Views\_ViewImports.cshtml"
using Hotel_Rental;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\Hotel_Rental\Hotel Rental\Views\_ViewImports.cshtml"
using Hotel_Rental.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\source\repos\Hotel_Rental\Hotel Rental\Views\_ViewImports.cshtml"
using Hotel.Core.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bd069e4739c826424dad66086cade00a2a2d7a3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f19a85b9bc0e029f0f9ecaf93c864ef67104c7a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserProductVM>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\source\repos\Hotel_Rental\Hotel Rental\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bd069e4739c826424dad66086cade00a2a2d7a33534", async() => {
                WriteLiteral(@"


    <div id=""container"">
    <div class=""row"">
      
      <div class=""col-lg-6 col-md-6 col-sm-12 col-xs-12 services mt-4"">
        <div class=""services__content"">
         <div class=""icon d-block fas fa-paper-plane""></div>
         
         <h3 class=""display-3--title mt-3"">Forget Busy Work,<br />
          Start Next Vacation</h3>
");
                WriteLiteral(@"         <p class=""lh-lg"">
          We provide what you need to enjoy your <br />
          holiday with family. Time to make another<br /> 
          memorable moments.
         </p>
        <a class=""round"" href=""#""> Show Me Now<span class=""to-right""></span> </a>
        </div>
      </div>
      <div class=""col-lg-6 col-md-6 col-sm-12 col-xs-12 services mt-4 text-end"">
        <div class=""services__pic"">
            <img src=""/images/image 3.png"" alt=""marketing illustration"" class=""img""> 
            
        </div>
      </div>
    </div>
   </div>



");
                WriteLiteral("\r\n\r\n   \r\n        <h1 class=\"picked\">");
#nullable restore
#line 71 "C:\Users\hp\source\repos\Hotel_Rental\Hotel Rental\Views\Home\Index.cshtml"
                      Write(Model.Categories[0].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n\r\n\r\n\r\n");
                WriteLiteral("        <section class=\"section1\">\r\n <div class=\"parent\">\r\n     <div class=\"child-1\">\r\n");
#nullable restore
#line 79 "C:\Users\hp\source\repos\Hotel_Rental\Hotel Rental\Views\Home\Index.cshtml"
             for(int i = 0; i < Model.MostPickerProducts.Count; i++)
            {
                if(i == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                      <div class=\"portfolio-box shadow\">\r\n                          <div> \r\n                        <img");
                BeginWriteAttribute("src", " src=", 2898, "", 2940, 1);
#nullable restore
#line 85 "C:\Users\hp\source\repos\Hotel_Rental\Hotel Rental\Views\Home\Index.cshtml"
WriteAttributeValue("", 2903, Model.MostPickerProducts[i].ImageUrl, 2903, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"portfolio 1 image\" class =\"img-fluid\">\r\n                        </div>\r\n                        <div class=\"portfolio-info\">\r\n                          <div class=\"caption\">\r\n                            <h4 class=\"fams\">");
#nullable restore
#line 89 "C:\Users\hp\source\repos\Hotel_Rental\Hotel Rental\Views\Home\Index.cshtml"
                                        Write(Model.MostPickerProducts[0].ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h4>\r\n                            <p class=\"w\">");
#nullable restore
#line 90 "C:\Users\hp\source\repos\Hotel_Rental\Hotel Rental\Views\Home\Index.cshtml"
                                    Write(Model.MostPickerProducts[0].Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <button type=\"button\" class=\"rounded\">$50 per night</button>\r\n                          </div>\r\n                        </div>\r\n                      </div>\r\n");
#nullable restore
#line 95 "C:\Users\hp\source\repos\Hotel_Rental\Hotel Rental\Views\Home\Index.cshtml"
                    
                    break;
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("         </div>\r\n        <div class=\"child-2\">\r\n\r\n\r\n");
#nullable restore
#line 103 "C:\Users\hp\source\repos\Hotel_Rental\Hotel Rental\Views\Home\Index.cshtml"
             for(int i = 0; i < Model.MostPickerProducts.Count; i++)
            {
                if(i != 0)
                {
                      

#line default
#line hidden
#nullable disable
                WriteLiteral("                     <div class=\"col-lg-4 col-md-6\">\r\n                      <div class=\"portfolio-box shadow\">\r\n                        <img");
                BeginWriteAttribute("src", " src=", 3916, "", 3958, 1);
#nullable restore
#line 110 "C:\Users\hp\source\repos\Hotel_Rental\Hotel Rental\Views\Home\Index.cshtml"
WriteAttributeValue("", 3921, Model.MostPickerProducts[i].ImageUrl, 3921, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" alt=""portfolio 2 image"" class=""food"">
                        <div class=""portfolio-info"">
                          <div class=""caption"">
                            <h4></h4>
                            <p></p>
                            <button type=""button"" class=""but"">$22 per night  </button>
                          </div>
                        </div>
                      </div>
                    </div>
");
#nullable restore
#line 120 "C:\Users\hp\source\repos\Hotel_Rental\Hotel Rental\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        \r\n");
                WriteLiteral("\r\n        </div>\r\n        \r\n        </div>\r\n        </section>\r\n       \r\n\r\n\r\n\r\n        <div");
                BeginWriteAttribute("class", " class=\"", 5995, "\"", 6003, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n        \r\n           <h1 class=\"beauty\">Houses with beauty backyard</h1>\r\n");
                WriteLiteral(@"   
           <div class=""parent-div"">
                 <div>
                <img src=""images/Image folder/Rect1.png"" alt=""portfolio 2 image"" class=""r1"">
                            <div class=""portfolio-info"">
                              <div class=""caption"">
                                <h4></h4>
                                <p></p>
                                <button type=""button"" class=""b3"">Popular Choice
          
                        </button>
                     </div>
             </div>
              </div>
                 <div>
                 <div");
                BeginWriteAttribute("class", " class=\"", 6776, "\"", 6784, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                      <div class=""portfolio-box shadow"">
                        <img src=""images/Image folder/Rect2.png"" alt=""portfolio 1 image"" class=""r2"">
                            <div class=""portfolio-info"">
                                  <div class=""caption"">
                                    <p></p>
                                   </div>
                            </div>
                        </div>
                   </div>
              </div>
            
                 <div>
                  <div class=""col-lg-4 col-md-6"">
                      <div class=""portfolio-box shadow"">
                                <img src=""images/Image folder/Rect3.png"" alt=""portfolio 2 image"" class=""r3"">
                                <div class=""portfolio-info"">
                                          <div class=""caption"">
                                            <h4></h4>
                                            <p></p>
                                          </div>
                WriteLiteral(@"
                                </div>
                      </div>
                </div>
             </div>
                 <div>
                <div class=""col-lg-4 col-md-6"">
                  <div class=""portfolio-box shadow"">
                        <img src=""images/Image folder/Rect4.png"" alt=""portfolio 1 image"" class=""r4"">
                            <div class=""portfolio-info"">
                                      <div class=""caption"">
                                        <h4></h4>
                                        <p></p>
                                      </div>
                            </div>
                  </div>
                  </div>
             
        </div>
           </div>
            
          
       
        </div>









       
        <div class=""col-lg-4 col-md-6"">
          <div><h1 class=""room"">Hotels with large living room</h1></div>



");
                WriteLiteral(@"
             <div class=""parent-div1 "">
                     <div class=""d-flex justify-content-between"">
                 
                 <img src=""images/Image folder/Rect5.png"" alt=""portfolio 1 image"" class=""r5"">
                 
                 
");
                WriteLiteral(@"                 
                <div>

                         <div class=""col-lg-4 col-md-6"">
                      <div class=""portfolio-box shadow"">
                                <img src=""images/Image folder/Rect6.png"" alt=""portfolio 1 image"" class=""r6"">
                                <div class=""portfolio-info"">
                                      <div class=""caption"">
                                        <h4></h4>
                                        <p></p>
                                      </div>
                                </div>
                      </div>
                   </div>

        <div>


            <div class=""col-lg-4 col-md-6"">
                  <div class=""portfolio-box shadow"">
                         <img src=""images/Image folder/Rect7.png"" alt=""portfolio 2 image"" class=""r7"">
                        <div class=""portfolio-info"">
                                  <div class=""caption"">
                                    <h4></h4>
       ");
                WriteLiteral(@"                             <p></p>
                                  </div>
                        </div>
                  </div>
            </div>

        </div>
            </div>
             
         
        </div>
            
                     <div  >

            <div class=""col-lg-4 col-md-6"">
          <div class=""portfolio-box shadow"">
            <img src=""images/Image folder/Rect8.png"" alt=""portfolio 1 image"" class=""r8"">
            <div class=""portfolio-info"">
              <div class=""caption"">
                <h4></h4>
                <p></p>
              </div>
            </div>
          </div>
        </div>


        </div>
        
       
                     <div");
                BeginWriteAttribute("class", " class=\"", 11599, "\"", 11607, 0);
                EndWriteAttribute();
                WriteLiteral(@">
          
             <div class=""d-flex justify-content-between"">
                 <div>
             <img src=""images/Image folder/Rect9.png"" alt=""portfolio 2 image"" class=""r9"">
                        <div class=""portfolio-info"">
                          <div class=""caption"">
                            <h4></h4>
                            <p></p>
                          </div>
                        </div>
                 </div>
             <div>

             </div>
          </div>

        </div>

                     <div class=""col-lg-4 col-md-6"">
         
            <img src=""images/Image folder/Rect10.png"" alt=""portfolio 1 image"" class=""r10"">
            <div class=""portfolio-info"">
              <div class=""caption"">
                <h4></h4>
                <p></p>
              </div>
            </div>
          </div>
             </div>
         

            
        </div>
        
        <div>
           
            <div><h1 class=""apart""");
                WriteLiteral(">Apartments with kitchen set</h1></div>\r\n\r\n");
                WriteLiteral(@"            <div class=""parent-div3"">

                 <div>
            <div class=""col-lg-4 col-md-6"">
          
            <img src=""images/Image folder/Rect11.png"" alt=""portfolio 2 image"" class=""r11"">
            <div class=""portfolio-info"">
              <div class=""caption"">
                <h4></h4>
                <p></p>
              </div>
            </div>
          </div>


             
            </div>

                 <div>
             <div class=""col-lg-4 col-md-6"">
         
            <img src=""images/Image folder/Rect12.png"" alt=""portfolio 1 image"" class=""r12"">
            <div class=""portfolio-info"">
              <div class=""caption"">
                <h4></h4>
                <p></p>
              </div>
            </div>
          </div>

       </div>
                 <div class=""col-lg-4 col-md-6"">
       
            <img src=""images/Image folder/Rect13.png"" alt=""portfolio 2 image"" class=""r13"">
            <div class=""portfolio-info"">
    ");
                WriteLiteral(@"          <div class=""caption"">
                <h4></h4>
                <p></p>
              </div>
            </div>
          </div>  

                 <div class=""portfolio-box shadow"">
            <img src=""images/Image folder/Rect14.png"" alt=""portfolio 1 image"" class=""r14"">
            <div class=""portfolio-info"">
 
                      
        <div class=""col-lg-4 col-md-6"">
        
            <img src=""images/Image folder/Happy Family.png"" alt=""family logo"" class=""fa"">
            <div class=""ratings"">
            <i class=""star"">&#9734;&#9734;&#9734;&#9734;&#9734;</i>
           <p class=""text"">What a great trip with my family and <br />
                 I should try again next time soon ...</p>
          </div>
          <a class=""read"" href=""#""> Read Their Story</a>
          
       
              <div class=""caption"">
                <h4></h4>
                <p></p>
              </div>
            </div>
          </div>
        </div> 

            </div>");
                WriteLiteral("\r\n        </div>\r\n        \r\n       \r\n        \r\n          \r\n     \r\n");
                WriteLiteral("        \r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    \r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserProductVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591