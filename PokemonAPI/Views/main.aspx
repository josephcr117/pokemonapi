<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="PokemonAPI.Views.main" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
    <title>Pokemon List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Pokémon List</h2>
            <div class="row">
                <asp:Repeater ID="pokemonRepeater" runat="server">
                    <ItemTemplate>
                        <div class="col-md-3 mb-4">
                            <div class="card" style="width: 100%; height: 100%;">
                                <img class="card-img-top" src='<%# Eval("ImageUrl") %>' alt='<%# Eval("Name") %>' style="max-height: 200px;">
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Name") %></h5>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <asp:Label ID="resultLabel" runat="server" />
        </div>
    </form>
</body>
</html>
