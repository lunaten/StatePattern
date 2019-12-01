<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="StatePattern.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <link rel="stylesheet" href="./Content/bootstrap-theme.css" />
    <link rel="stylesheet" href="./Content/bootstrap.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            予約区分
            <asp:RadioButtonList ID="rbBookingKbn" runat="server">
                <asp:ListItem Value="0" Text="講義" Selected="True" />
                <asp:ListItem Value="1" Text="休講"  />
                <asp:ListItem Value="2" Text="補講"  />
                <asp:ListItem Value="3" Text="スポット"  />
            </asp:RadioButtonList>
            <asp:LinkButton ID="lnkBtnBooking" runat="server" OnClick="lnkBtnBooking_Click" CssClass="btn-info">予約する</asp:LinkButton>
        </div>
        <br />
        <div>
            申請種別
            <asp:RadioButtonList ID="rbShinseiKind" runat="server">
                <asp:ListItem Value="0" Text="休講・補講" Selected="True" />
                <asp:ListItem Value="1" Text="休講"  />
                <asp:ListItem Value="2" Text="補講"  />
            </asp:RadioButtonList>
            申請区分
            <asp:RadioButtonList ID="rbShinseiKbn" runat="server">
                <asp:ListItem Value="0" Text="新規" Selected="True" />
                <asp:ListItem Value="1" Text="修正"  />
                <asp:ListItem Value="2" Text="補講日登録"  />
                <asp:ListItem Value="3" Text="取消"  />
            </asp:RadioButtonList>
            <asp:LinkButton ID="lnkBtnShinsei" runat="server" OnClick="lnkBtnShinsei_Click" CssClass="btn-info">申請する</asp:LinkButton>
        </div>
    </form>
</body>
</html>
