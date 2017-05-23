using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using classlib;

namespace AngularFundamentals.Services
{
    /// <summary>
    /// Summary description for svTurtles
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class svTurtles : System.Web.Services.WebService
    {

        [WebMethod]
        public void GetAllTurtles()
        {
            List<clsTurtles> a = new List<clsTurtles>();
            var b = clsTurtles.GetAllTurtles().Select(x => new
            {
                type = x.type,
                flag = x.flag,
                locations = x.locations,
                size = x.size,
                lifespan = x.lifespan,
                diet = x.diet,
                description = x.description
            });           
            foreach(var i in b.ToList())
            {
                clsTurtles c = new clsTurtles();
                c.type = i.type.ToString();
                c.flag = i.flag.ToString();
                c.locations = i.locations.ToString();
                c.size = i.size.ToString();
                c.lifespan = i.lifespan.ToString();
                c.diet = i.diet.ToString();
                c.description = i.description.ToString();

                a.Add(c);
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(a));
        }

        [WebMethod]
        public void GetAllTurtlesQuiz()
        {          
            List<clsTurtlesQuiz> b = new List<clsTurtlesQuiz>();
            var a = clsTurtlesQuiz.GetAllTurtlesQuiz().Select(x => new
            {
                id = x.id,
                type = x.type,
                question = x.question,
                ans1 = x.ans1,
                ans2 = x.ans2,
                ans3 = x.ans3,
                ans4 = x.ans4,
                selected = x.selected,
                correct = x.correct,
                score = x.score
            });
            foreach (var i in a.ToList())
            {
                clsTurtlesQuiz c = new clsTurtlesQuiz();
                c.id = Convert.ToInt32(i.id);
                c.type = i.type;
                c.question = i.question;
                c.ans1 = i.ans1;
                c.ans2 = i.ans2;
                c.ans3 = i.ans3;
                c.ans4 = i.ans4;
                c.selected = i.selected;
                c.correct = i.correct;
                c.score = i.score;
                b.Add(c);
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(b));
        }
    }
}
