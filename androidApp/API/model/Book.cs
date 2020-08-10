using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace androidApp.API.model
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Gerne { get; set; }

        public string Detail { get; set; }

        public string Other { get; set; }

        public string JAN { get; set; }

    }
}