<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<int?>" %>

<%: Html.Kendo().IntegerTextBoxFor(m => m)
      .HtmlAttributes(new { style = "width:100%" })
      .Min(int.MinValue)
      .Max(int.MaxValue)
%>