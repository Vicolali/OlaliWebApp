<%@ Page Title="Swapi API" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GetSWAPI.aspx.cs" Inherits="OlaliWebApplication2.GetSWAPI" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>
        <span style="color: rgb(200, 200, 200); font-family: &quot; helvetica neue&quot; , helvetica, arial, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(39, 43, 48); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">The Star Wars API (or &quot;swapi&quot;) is the world&#39;s first quantified and programmatically-accessible data source for all the data from the Star Wars canon universe!</span>
    </p>
<center>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Click here for SWAPI Characters" OnClick="Button1_Click" />

    </div>
    <br />
    <div>
        <h4>
            <asp:Label ID="Label1" runat="server" ForeColor="Blue"></asp:Label></h4>
     
    </div>

     <br />
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>

    </center>



</asp:Content>
