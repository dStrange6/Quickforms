//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_UserProfile_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_UserProfile_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\Invia-ILC\AppData\Local\Temp\1F0F42731E11F426EBB7859BD24B1E8DBC82\4\FormBuilder_V1-master\FormBuilder_V1\Views\User\UserProfile.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\Invia-ILC\AppData\Local\Temp\1F0F42731E11F426EBB7859BD24B1E8DBC82\4\FormBuilder_V1-master\FormBuilder_V1\Views\User\UserProfile.cshtml"
  
    ViewBag.Title = "UserProfile";


#line default
#line hidden

#line 3 "C:\Users\Invia-ILC\AppData\Local\Temp\1F0F42731E11F426EBB7859BD24B1E8DBC82\4\FormBuilder_V1-master\FormBuilder_V1\Views\User\UserProfile.cshtml"
                   __o = Html.DisplayName("Form Name");


#line default
#line hidden

#line 4 "C:\Users\Invia-ILC\AppData\Local\Temp\1F0F42731E11F426EBB7859BD24B1E8DBC82\4\FormBuilder_V1-master\FormBuilder_V1\Views\User\UserProfile.cshtml"
                   __o = Html.DisplayName("Date Added");


#line default
#line hidden

#line 5 "C:\Users\Invia-ILC\AppData\Local\Temp\1F0F42731E11F426EBB7859BD24B1E8DBC82\4\FormBuilder_V1-master\FormBuilder_V1\Views\User\UserProfile.cshtml"
                foreach (var item in Model)
                {
                    

#line default
#line hidden

#line 6 "C:\Users\Invia-ILC\AppData\Local\Temp\1F0F42731E11F426EBB7859BD24B1E8DBC82\4\FormBuilder_V1-master\FormBuilder_V1\Views\User\UserProfile.cshtml"
                                    __o = item.Template_ID;


#line default
#line hidden

#line 7 "C:\Users\Invia-ILC\AppData\Local\Temp\1F0F42731E11F426EBB7859BD24B1E8DBC82\4\FormBuilder_V1-master\FormBuilder_V1\Views\User\UserProfile.cshtml"
                       __o = Html.DisplayFor(modelItem => item.TemplateName);


#line default
#line hidden

#line 8 "C:\Users\Invia-ILC\AppData\Local\Temp\1F0F42731E11F426EBB7859BD24B1E8DBC82\4\FormBuilder_V1-master\FormBuilder_V1\Views\User\UserProfile.cshtml"
                       __o = Html.DisplayFor(modelItem => item.DateAdded);


#line default
#line hidden

#line 9 "C:\Users\Invia-ILC\AppData\Local\Temp\1F0F42731E11F426EBB7859BD24B1E8DBC82\4\FormBuilder_V1-master\FormBuilder_V1\Views\User\UserProfile.cshtml"
                                                                                              __o = item.Template_ID;


#line default
#line hidden

#line 10 "C:\Users\Invia-ILC\AppData\Local\Temp\1F0F42731E11F426EBB7859BD24B1E8DBC82\4\FormBuilder_V1-master\FormBuilder_V1\Views\User\UserProfile.cshtml"
                                                                                                      __o = item.Template_ID;


#line default
#line hidden

#line 11 "C:\Users\Invia-ILC\AppData\Local\Temp\1F0F42731E11F426EBB7859BD24B1E8DBC82\4\FormBuilder_V1-master\FormBuilder_V1\Views\User\UserProfile.cshtml"
                                                                                                   __o = item.Template_ID;


#line default
#line hidden

#line 12 "C:\Users\Invia-ILC\AppData\Local\Temp\1F0F42731E11F426EBB7859BD24B1E8DBC82\4\FormBuilder_V1-master\FormBuilder_V1\Views\User\UserProfile.cshtml"
                         
                }

#line default
#line hidden
}
}
}
