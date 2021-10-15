using System;
using System.Collections.Generic;
using System.Text;
using WebPage.model;

[assembly: Xamarin.Forms.Dependency(typeof(BaseUrlInterface))]
namespace WebPage.model
{
    interface IBaseUrl
    {
        string Get();
        
    }
}
