<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Zadanie11.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <%--Usuwamy ta linijkę opakowujac ja obiektem UpdatePanel--%>
            <%--<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>--%>
            <asp:Timer ID="Timer1" runat="server" Interval="100" OnTick="Timer1_Tick"></asp:Timer>
            <%--tylko wnętrze tego panelu bedzie przeładowywane--%>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <%--tworzymy nowy UpdatePanel o nazwie UpdatePanel1--%>
                <Triggers>
                    <%--Teraz musimy określić co będzie wyzwalać przeładowanie panela --%>
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                    <%-- INFO: ControlID ustawia nam obiekt, który będzie źrudłem syganłu 
                        do przeładowania EventName to informacja jakie zdarzenie obiektu zadeklarowanego w
                        ControlID ma być wyzwalaczem przeładowania 
                        W naszym wyatku nasłuchujemy zdarzenia Tick --%>
                </Triggers>
                <ContentTemplate>
                    <%--Tutaj umieszczamy elementy, które mają sie przeładowac --%>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
