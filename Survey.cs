using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Models.Home
{
    public class Survey
    {
        public string StudentName {get; set; }
        public string Location {get; set; }
        public string FavLanguage {get; set; }
        public string Comment {get; set; }
    }
}