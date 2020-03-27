using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OlaliWebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Is_Prime_Click(object sender, EventArgs e)
        {
            var s1 = System.Diagnostics.Stopwatch.StartNew();

            this.Label2.Text = Convert.ToString(Prime_Checker(Int32.Parse(this.TextBox1.Text)));
            s1.Stop();
            this.Label3.Text = "Duration in ms: " + Convert.ToString(s1.Elapsed.TotalMilliseconds);

        }

        protected void Memoize_Click(object sender, EventArgs e)
        {
            //Memoize_Click
            var s2 = System.Diagnostics.Stopwatch.StartNew();
            this.Label4.Text = Convert.ToString(Memoize(Prime_Checker, Int32.Parse(this.TextBox2.Text)));
            s2.Stop();
            this.Label5.Text = "Duration in ms: " + (Convert.ToString(s2.Elapsed.TotalMilliseconds));
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Char[] separator = { ' ', ',' };
            String[] ST = this.TextBox3.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            this.Label7.Text = BinarySearch(ST, Int32.Parse(this.TextBox4.Text));
            
        }

        



        // static Boolean Prime_Checker(int n) //- This is one way of doing it,
        Func<int, Boolean> Prime_Checker = (n) => // This is another way. This one ends with semi-colon
          {
              int flag = 0;
              Thread.Sleep(2000);
              for (int i = 2; i <= n / 2; ++i)
              {

                // condition for non-prime
                if (n % i == 0)
                  {
                      flag = 1;
                      break;
                  }
              }

              if (n == 1)
                  return false;
              else if (flag == 0)
                  return true;
              else
                  return false;
          };

        // Create a dictionary for caching ... call it 'Memoizer'
        static Dictionary<String, Boolean> Memoizer = new Dictionary<String, Boolean>();

        //Memoize is a higher order function. It can be Action or Func. Let's use Func coz it returns something.
        static Boolean Memoize(Func<int , Boolean> MyFunction, int y)
        {
            
            Boolean myResult;
            string FName = Convert.ToString(MyFunction.GetType())+ Convert.ToString(y);
           
            // if found
            if (Memoizer.TryGetValue(FName, out myResult))
            {
                return myResult;
            }
            else

            //if not found
            myResult = MyFunction(y);
            Memoizer[FName] = myResult;
            return myResult;

        }

        static string BinarySearch(String[] myArray, int searchKey)
        {
            int minNum = 0;
            int maxNum = myArray.Length - 1;
            string myResult = "Key not found";

            while (minNum <= maxNum)
            {
                int midPosition = (minNum + maxNum) / 2;
                if (searchKey == Int32.Parse(myArray[midPosition]))
                {
                    myResult = "Index of "+searchKey+" is "+Convert.ToString(midPosition);
                    return myResult;
                }
                else if (searchKey < Int32.Parse(myArray[midPosition]))
                {
                    maxNum = midPosition - 1;
                }
                else
                {
                    minNum = midPosition + 1;
                }
            }
            return myResult;
        }

        public static object Search(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "Nil";
        }


    }
}