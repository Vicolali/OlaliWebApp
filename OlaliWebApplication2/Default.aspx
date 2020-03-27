<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OlaliWebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Olali - Web App</h1>
        <p class="lead" aria-atomic="True">On this page, we will implement a few functions:</p>
    </div>

    <div>
       <div>
         <!--div class="col-md-4"-->
            <h2>Is it Prime ?</h2>
            <p>
                
                Enter your value in the text box and then click the button <b>"is prime"</b>. This will check if the value entered is a prime number.
            </p>
            <p>
                &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Is_Prime_Click" Text="Is Prime ?" />
                </p><p>
                <asp:Label ID="Label1" runat="server" Text="RESULT WILL APPEAR BELOW "></asp:Label>
              </p>
           <p>

           <h3>
           <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="Blue"></asp:Label>
           &nbsp;&nbsp;&nbsp; <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="RED"></asp:Label>
           </h3> 
             <p>
                <a class="btn btn-default" href="https://en.wikipedia.org/wiki/Prime_number">Learn more &raquo;</a>
            </p>
           <hr />
        </div>
        <div">
            <h2>The Memoize Function</h2>
            <p>
                This will memoize the function "is prime" above. For comparison, the time taken to execute will be displayed next to the result for each method. Try with <b>2147483647</b>
            </p>
            <p>
                &nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Memoize_Click" Text="Memoized Prime"  />
                </p><p>
                <asp:Label ID="Label6" runat="server" Text="RESULT WILL APPEAR BELOW "></asp:Label>
              </p>
            <h3>
           <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="Blue"></asp:Label>
           &nbsp;&nbsp;&nbsp; <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="RED"></asp:Label>
           </h3>
            <p>
                <a class="btn btn-default" href="https://en.wikipedia.org/wiki/Memoization">Learn more &raquo;</a>
            </p>
            <hr />
        </div>
        <div>
            <h2>The Binary Search</h2>
            <p>
               This will perform a binary search on the collection provided. 
            </p>
            
            <div>
               
                <table ID="Table1" runat="server" Width="626px" Height="162px">
                    <tr runat="server"><td> Key in or paste your collection of values. Use space or commas as separators:</td>
                        <td>
                      <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr runat="server"><td>Key in a value to find in the collection:</td><td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr runat="server"><td>
                        <asp:Button ID="Button3" runat="server" Text="Execute Binary Search" OnClick="Button3_Click" />
                        </td><td>
                          <h3>  <asp:Label ID="Label7" runat="server" ForeColor="Blue"></asp:Label></h3></td>
                    </tr>
                </table>
                
            </div> 
           
            <p>
                &nbsp;</p>
          
            <p>
                <a class="btn btn-default" href="https://en.wikipedia.org/wiki/Binary_search_algorithm">Learn more &raquo;</a>
            </p>
            <hr />
        </div>
        <div">
            <h2>The SWAP API</h2>
            <p>
                This feature will display a list of the Star Wars characters and their attributes in a table
            </p>
    
            <p>
                <a class="btn btn-default" href="GetSWAPI">Click here to Check out the SWAPI API &raquo;</a>
            </p>
            <hr />
        </div>
    </div>

</asp:Content>
