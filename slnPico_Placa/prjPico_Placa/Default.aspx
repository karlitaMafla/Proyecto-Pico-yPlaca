<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="prjPico_Placa._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h3 style="font: italic bold 24px Georgia, serif;">Software de Manejo de Pico y Placa</h3>

        <div class="jumbotron" style="border: 2px solid #423E3B;">
            
            <Table style="border-radius: 25px;border: 0px solid #423E3B;">
                <tr>
                    <td style="width: 208px">
                        <asp:Label ID="Label1" runat="server" Text="Ingrese la Placa del vehiculo: " style="font: italic bold 12px Georgia, serif;"></asp:Label>  
                    </td>
                    <td>
                        <asp:TextBox ID="txtplaca" runat="server" Width="156px"></asp:TextBox>  
                    </td>
                </tr>
                <tr>
                    <td style="width: 208px; height: 20px;">
                        
                    </td>
                    <td style="height: 20px">
                         
                    </td>
                </tr>
                <tr>
                    <td style="height: 25px; width: 208px;">
                        <asp:Label ID="Label2" runat="server" Text="Ingrese la Fecha (dd/mm/yy): " style="font: italic bold 12px Georgia, serif;"></asp:Label>  
                    </td>
                    <td style="height: 25px">
                        <asp:TextBox ID="txtfecha" runat="server" Width="157px"></asp:TextBox>
                    </td>
                    <td style="height: 25px; width: 50px;">
                        
                    </td>
                    <td style="height: 25px; width: 126px;">
                        <asp:Label ID="Label3" runat="server" Text="Selecione la hora:" style="font: italic bold 12px Georgia, serif;"></asp:Label>
                    </td>
                    <td style="height: 25px; width: 44px;">
                        <select id="hora" runat="server">
                            <option value="00">00</option>
                            <option value="01">01</option>
                            <option value="02">02</option>
                            <option value="03">03</option>
                            <option value="04">04</option>
                            <option value="05">05</option>
                            <option value="06">06</option>
                            <option value="07">07</option>
                            <option value="08">08</option>
                            <option value="09">09</option>
                            <option value="10">10</option>
                            <option value="11">11</option>
                            <option value="12">12</option>
                            <option value="13">13</option>
                            <option value="14">14</option>
                            <option value="15">15</option>
                            <option value="16">16</option>
                            <option value="17">17</option>
                            <option value="18">18</option>
                            <option value="19">19</option>
                            <option value="20">20</option>
                            <option value="21">21</option>
                            <option value="22">22</option>
                            <option value="23">23</option>
                        </select>
                    </td>
                    
                     <td>
                         <asp:Label ID="Label4" runat="server" Text=":" style="font: italic bold 14px Georgia, serif;"></asp:Label>
                     </td>
                    <td style="height: 25px; width: 54px;">
                        <select id="minutos" runat="server">
                            <option value="0">00</option>
                            <option value="05">05</option>
                            <option value="10">10</option>
                            <option value="15">15</option>
                            <option value="20">20</option>
                            <option value="25">25</option>
                            <option value="30">30</option>
                            <option value="35">35</option>
                            <option value="40">40</option>
                            <option value="45">45</option>
                            <option value="50">50</option>
                            <option value="55">55</option>
                            <option value="60">60</option>
                        </select>
                    </td>
                    
                </tr>
            </Table>

        </div>
        <asp:Button ID="btnResultado"  runat="server" OnClick="btnResultado_Click" Text="Obtener Resultado" Width="170px" style="border-radius: 25px;border: 1px solid #423E3B;font: italic bold 14px Georgia, serif;" Height="38px"/>
    </div>

    

</asp:Content>
