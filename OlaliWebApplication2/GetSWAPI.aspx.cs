using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OlaliWebApplication2
{
    public partial class GetSWAPI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();

            //rClient.endpoint = "https://swapi.co/api/people/" + TextBox5.Text + "/";
            rClient.endpoint = "https://swapi.co/api/people/";

            // make request to get JSON
            String rawJSON = rClient.makeRequest();

            //convert JSON string to a series of objects
            People people = JsonConvert.DeserializeObject<People>(rawJSON);
            Person[] person = new Person[people.Results.Count] ;

            //this.Label1.Text = Convert.ToString(people.Results.Count) + " records were found.";
            this.Label1.Text = Convert.ToString(people.Results.Count) + " records were found. ";

            DataTable dt = new DataTable();

            //Creating my table headers
            StringBuilder myTable = new StringBuilder();
            myTable.Append("<table cellpadding='10'><tr><th>");
            myTable.Append(dt.Columns.Add("Name",Type.GetType("System.String")));
            myTable.Append("</th><th>");
            myTable.Append(dt.Columns.Add("Gender", Type.GetType("System.String")));
            myTable.Append("</th><th>");
            myTable.Append(dt.Columns.Add("Y.O.B", Type.GetType("System.String")));
            myTable.Append("</th><th>");
            myTable.Append(dt.Columns.Add("Hair", Type.GetType("System.String")));
            myTable.Append("</th><th>");
            myTable.Append(dt.Columns.Add("skin_color", Type.GetType("System.String")));
            myTable.Append("</th><th>");
            myTable.Append(dt.Columns.Add("More", Type.GetType("System.String")));
            myTable.Append("</th><th>");
            myTable.Append(dt.Columns.Add("Favourite", Type.GetType("System.Boolean"))); // to check later
            myTable.Append("</th></tr>");
            
            //Creating my table data

            for (int v = 0; v < people.Results.Count; v++)
            {
                person[v] = people.Results[v];

                myTable.Append("<tr>");
                dt.Rows.Add();

                myTable.Append("<td>");
                myTable.Append(dt.Rows[dt.Rows.Count - 1]["Name"] = person[v].Name);
                myTable.Append("</td>");
                myTable.Append("<td>");
                myTable.Append(dt.Rows[dt.Rows.Count - 1]["Gender"] = person[v].Gender);
                myTable.Append("</td>");
                myTable.Append("<td>");
                myTable.Append(dt.Rows[dt.Rows.Count - 1]["Y.O.B"] = person[v].Birth_year);
                myTable.Append("</td>");
                myTable.Append("<td>");
                myTable.Append(dt.Rows[dt.Rows.Count - 1]["Hair"] = person[v].Hair_color);
                myTable.Append("</td>");
                myTable.Append("<td>");
                myTable.Append(dt.Rows[dt.Rows.Count - 1]["skin_color"] = person[v].Skin_color);
                myTable.Append("</td>");
                myTable.Append("<td>");
                myTable.Append(dt.Rows[dt.Rows.Count - 1]["More"] = "<a href='" + person[v].Url + "'>Learn more</a>");
                myTable.Append("</td>");
                myTable.Append("<td>");
                myTable.Append(dt.Rows[dt.Rows.Count - 1]["Favourite"] = false); // To Do later
                myTable.Append("</td>");

                myTable.Append("</tr>");
            }

            myTable.Append("</ table >");

            PlaceHolder1.Controls.Add(new Literal { Text = myTable.ToString() });
        }
    }
}