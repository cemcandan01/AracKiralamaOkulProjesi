<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ilanlar.aspx.cs" Inherits="AracKiralamaProjesi.Ilanlar" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"><title></title></head>
<body>
    <form runat ="server">
        <h1>İlanlar</h1>
        <table >
            <tr>
                <td>Marka:</td>
                <td><asp:TextBox ID="txt_marka" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Model:</td>
                <td><asp:TextBox ID="txt_model" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Seri:</td>
                <td><asp:TextBox ID="txt_seri" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Yıl:</td>
                <td><asp:TextBox ID="txt_yil" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Plaka:</td>
                <td><asp:TextBox ID="txt_plaka" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Kilometre:</td>
                <td><asp:TextBox ID="txt_km" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Kasa Tipi:</td>
                <td><asp:TextBox ID="txt_kasa" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Günlük Ücret:</td>
                <td><asp:TextBox ID="txt_ucret" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Renk:</td>
                <td><asp:TextBox ID="txt_renk" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Yakıt Türü:</td>
                <td><asp:TextBox ID="txt_yakit" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Button ID="btn_ekle" runat="server" Text="Ekle" OnClick="btn_ekle_Click" />
        <asp:Button ID="btn_goster" runat="server" Text="Araçları Göster" OnClick="btn_goster_Click" />
        <br />
        <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
    </form>
    
</body>
</html>
