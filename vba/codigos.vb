
let
    Fonte = Xml.Tables(File.Contents("D:\ml01\Desktop\Dev\vendas-helps\vba\vendas-ph.xml")),
    #"Tipo Alterado" = Table.TransformColumnTypes(Fonte,{{"Attribute:Version", Int64.Type}}),
    #"Colunas Removidas" = Table.RemoveColumns(#"Tipo Alterado",{"METADATA", "Attribute:Version"}),
    #"ROWDATA Expandido" = Table.ExpandTableColumn(#"Colunas Removidas", "ROWDATA", {"ROW"}, {"ROWDATA.ROW"}),
    #"ROWDATA.ROW Expandido" = Table.ExpandTableColumn(#"ROWDATA Expandido", "ROWDATA.ROW", {"Attribute:SITUACAO", "Attribute:RAZAOSOCIAL", "Attribute:CIDADE", "Attribute:UF", "Attribute:VENDEDOR", "Attribute:EXTERNO", "Attribute:CGC", "Attribute:CODORCAMENTO", "Attribute:DATA", "Attribute:NF", "Attribute:VENDEDOR_VENDA", "Attribute:TOTAL"}, {"ROWDATA.ROW.Attribute:SITUACAO", "ROWDATA.ROW.Attribute:RAZAOSOCIAL", "ROWDATA.ROW.Attribute:CIDADE", "ROWDATA.ROW.Attribute:UF", "ROWDATA.ROW.Attribute:VENDEDOR", "ROWDATA.ROW.Attribute:EXTERNO", "ROWDATA.ROW.Attribute:CGC", "ROWDATA.ROW.Attribute:CODORCAMENTO", "ROWDATA.ROW.Attribute:DATA", "ROWDATA.ROW.Attribute:NF", "ROWDATA.ROW.Attribute:VENDEDOR_VENDA", "ROWDATA.ROW.Attribute:TOTAL"}),
    #"Colunas Renomeadas" = Table.RenameColumns(#"ROWDATA.ROW Expandido",{{"ROWDATA.ROW.Attribute:SITUACAO", "SITUACAO"}, {"ROWDATA.ROW.Attribute:RAZAOSOCIAL", "RAZAOSOCIAL"}, {"ROWDATA.ROW.Attribute:CIDADE", "CIDADE"}, {"ROWDATA.ROW.Attribute:UF", "UF"}, {"ROWDATA.ROW.Attribute:VENDEDOR", "VENDEDOR"}, {"ROWDATA.ROW.Attribute:EXTERNO", "EXTERNO"}, {"ROWDATA.ROW.Attribute:CGC", "CGC"}}),
    #"Texto Extraído Antes do Delimitador" = Table.TransformColumns(#"Colunas Renomeadas", {{"ROWDATA.ROW.Attribute:DATA", each Text.BeforeDelimiter(_, "T"), type text}}),
    #"Tipo Alterado com Localidade" = Table.TransformColumnTypes(#"Texto Extraído Antes do Delimitador", {{"ROWDATA.ROW.Attribute:DATA", type date}}, "pt-BR"),
    #"Colunas Renomeadas1" = Table.RenameColumns(#"Tipo Alterado com Localidade",{{"ROWDATA.ROW.Attribute:CODORCAMENTO", "CODORCAMENTO"}, {"ROWDATA.ROW.Attribute:DATA", "DATA"}, {"ROWDATA.ROW.Attribute:NF", "NF"}, {"ROWDATA.ROW.Attribute:VENDEDOR_VENDA", "VENDEDOR_VENDA"}, {"ROWDATA.ROW.Attribute:TOTAL", "TOTAL"}}),
    #"Valor Substituído" = Table.ReplaceValue(#"Colunas Renomeadas1",".",",",Replacer.ReplaceText,{"TOTAL"}),
    #"Tipo Alterado com Localidade1" = Table.TransformColumnTypes(#"Valor Substituído", {{"TOTAL", Currency.Type}}, "pt-BR"),
    #"Tipo Alterado1" = Table.TransformColumnTypes(#"Tipo Alterado com Localidade1",{{"NF", type text}, {"CODORCAMENTO", type text}, {"CGC", type text}}),
    #"Linhas Agrupadas" = Table.Group(#"Tipo Alterado1", {"CGC", "RAZAOSOCIAL"}, {{"Contagem", each Table.RowCount(_), Int64.Type}, {"soma", each List.Sum([TOTAL]), type nullable number}})
in
    #"Linhas Agrupadas"









































Let
Fonte = Xml.Tables(File.Contents("D:\vendas11\Desktop\MAYCON\vendas-helps\vba\clientes-maycon.xml")),
#"Tipo Alterado" = Table.TransformColumnTypes(Fonte,{{"Attribute:Version", Int64.Type}}),
#"Colunas Removidas" = Table.RemoveColumns(#"Tipo Alterado",{"METADATA", "Attribute:Version"}),
#"ROWDATA Expandido" = Table.ExpandTableColumn(#"Colunas Removidas", "ROWDATA", {"ROW"}, {"ROWDATA.ROW"}),
#"ROWDATA.ROW Expandido" = Table.ExpandTableColumn(#"ROWDATA Expandido", "ROWDATA.ROW", {"Attribute:SITUACAO", "Attribute:RAZAOSOCIAL", "Attribute:CIDADE", "Attribute:UF", "Attribute:CGC", "Attribute:ULTIMACOMPRA", "Attribute:FONE", "Attribute:EMAIL"}, {"ROWDATA.ROW.Attribute:SITUACAO", "ROWDATA.ROW.Attribute:RAZAOSOCIAL", "ROWDATA.ROW.Attribute:CIDADE", "ROWDATA.ROW.Attribute:UF", "ROWDATA.ROW.Attribute:CGC", "ROWDATA.ROW.Attribute:ULTIMACOMPRA", "ROWDATA.ROW.Attribute:FONE", "ROWDATA.ROW.Attribute:EMAIL"}),
#"Colunas Renomeadas" = Table.RenameColumns(#"ROWDATA.ROW Expandido",{{"ROWDATA.ROW.Attribute:CGC", "CGC"}, {"ROWDATA.ROW.Attribute:UF", "UF"}, {"ROWDATA.ROW.Attribute:CIDADE", "CIDADE"}, {"ROWDATA.ROW.Attribute:RAZAOSOCIAL", "RAZAOSOCIAL"}, {"ROWDATA.ROW.Attribute:SITUACAO", "SITUACAO"}, {"ROWDATA.ROW.Attribute:ULTIMACOMPRA", "ULTIMACOMPRA"}, {"ROWDATA.ROW.Attribute:FONE", "FONE"}, {"ROWDATA.ROW.Attribute:EMAIL", "EMAIL"}}),
#"Valor SubstituíDo" = Table.ReplaceValue(#"Colunas Renomeadas",null,"n@o.tem",Replacer.ReplaceValue,{"EMAIL"}),
#"Valor Substituído1" = Table.ReplaceValue(#"Valor SubstituíDo",null,"(00) 00000-0000",Replacer.ReplaceValue,{"FONE"}),
#"Tipo Alterado com Localidade" = Table.TransformColumnTypes(#"Valor Substituído1", {{"ULTIMACOMPRA", type date}}, "pt-BR"),
#"Valor Substituído2" = Table.ReplaceValue(#"Tipo Alterado com Localidade",null,#date(1990, 1, 1),Replacer.ReplaceValue,{"ULTIMACOMPRA"}),
#"Tipo Alterado1" = Table.TransformColumnTypes(#"Valor Substituído2",{{"CGC", type text}}),
#"Linhas Classificadas" = Table.Sort(#"Tipo Alterado1",{{"ULTIMACOMPRA", Order.Ascending}})
in
#"Linhas Classificadas"








Let
Fonte = Xml.Tables(File.Contents("D:\vendas11\Desktop\MAYCON\vendas-helps\vba\clientes-ph.xml")),
#"Tipo Alterado" = Table.TransformColumnTypes(Fonte,{{"Attribute:Version", Int64.Type}})
in
#"Tipo Alterado"










'
Dim pathToXML As String


With Application.FileDialog(msoFileDialogFilePicker)
    .Filters.Clear


    .AllowMultiSelect = False
    .Filters.Add "XML", "*.xml"



    If .Show = -1 Then
        Dim clientes As ListObject

        pathToXML = .SelectedItems.Item(1)
        ' Worksheets(1).QueryTables(1).Connection = "XML;"& pathToXML
        Set clientes = Sheets("Clientes").Range("A1").ListObject
        Let prox = "A"
        With clientes.XmlMap.DataBinding
            .ClearSettings
            .LoadSettings pathToXML
            .Refresh
        End With

        ' Let sNewURL = pathToXML

        '--edit To the location of your data table
        'Set tbl = Sheets("Clientes").Range("A1").ListObject
        'Range("A1").ListObject

        ' With tbl.XmlMap.DataBinding
        ' .ClearSettings
        ' .LoadSettings sNewURL
        ' .Refresh
        ' End With

        ' ActiveWorkbook.XmlMaps("lista_clientes").Import Url:=.SelectedItems(1)
        ', Overwrite:=False



        ' ActiveWorkbook.XmlMaps("lista_clientes").PreserveNumberFormatting
    End If
End With

ActiveWorkbook.Queries.Item("meus-clientes").Formula = _
"Let" & Chr(10) & "    Fonte = Xml.Tables(File.Contents(""D:\vendas11\Desktop\MAYCON\vendas-helps\vba\clientes-ph.xml""))," & Chr(10) & "    #""Tipo Alterado"" = Table.TransformColumnTypes(Fonte,{{""Attribute:Version"", Int64.Type}})," & Chr(10) & "    #""Colunas Removidas"" = Table.RemoveColumns(#""Tipo Alterado"",{""METADATA"", ""Attribute:Version""})," & Chr(10) & "    #""ROWDATA Expandido"" = Table.ExpandTableColumn(#" & _
"""Colunas Removidas"", ""ROWDATA"", {""ROW""}, {""ROWDATA.ROW""})," & Chr(10) & "    #""ROWDATA.ROW Expandido"" = Table.ExpandTableColumn(#""ROWDATA Expandido"", ""ROWDATA.ROW"", {""Attribute:SITUACAO"", ""Attribute:RAZAOSOCIAL"", ""Attribute:CIDADE"", ""Attribute:UF"", ""Attribute:CGC"", ""Attribute:ULTIMACOMPRA"", ""Attribute:FONE"", ""Attribute:EMAIL""}, {""ROWDATA.ROW.Attribu" & _
"te:SITUACAO"", ""ROWDATA.ROW.Attribute:RAZAOSOCIAL"", ""ROWDATA.ROW.Attribute:CIDADE"", ""ROWDATA.ROW.Attribute:UF"", ""ROWDATA.ROW.Attribute:CGC"", ""ROWDATA.ROW.Attribute:ULTIMACOMPRA"", ""ROWDATA.ROW.Attribute:FONE"", ""ROWDATA.ROW.Attribute:EMAIL""})," & Chr(10) & "    #""Colunas Renomeadas"" = Table.RenameColumns(#""ROWDATA.ROW Expandido"",{{""ROWDATA.ROW.Attribute:CGC"", """ & _
"CGC""}, {""ROWDATA.ROW.Attribute:UF"", ""UF""}, {""ROWDATA.ROW.Attribute:CIDADE"", ""CIDADE""}, {""ROWDATA.ROW.Attribute:RAZAOSOCIAL"", ""RAZAOSOCIAL""}, {""ROWDATA.ROW.Attribute:SITUACAO"", ""SITUACAO""}, {""ROWDATA.ROW.Attribute:ULTIMACOMPRA"", ""ULTIMACOMPRA""}, {""ROWDATA.ROW.Attribute:FONE"", ""FONE""}, {""ROWDATA.ROW.Attribute:EMAIL"", ""EMAIL""}})," & Chr(10) & "    #""Val" & _
"Or SubstituíDo"" = Table.ReplaceValue(#""Colunas Renomeadas"",null,""n@o.tem"",Replacer.ReplaceValue,{""EMAIL""})," & Chr(10) & "    #""Valor Substituído1"" = Table.ReplaceValue(#""Valor SubstituíDo"",null,""(00) 00000-0000"",Replacer.ReplaceValue,{""FONE""})," & Chr(10) & "    #""Tipo Alterado com Localidade"" = Table.TransformColumnTypes(#""Valor Substituído1"", {{""ULTIMACOMPRA"", type date" & _
"}}, ""pt-BR"")," & Chr(10) & "    #""Valor Substituído2"" = Table.ReplaceValue(#""Tipo Alterado com Localidade"",null,#date(1990, 1, 1),Replacer.ReplaceValue,{""ULTIMACOMPRA""})," & Chr(10) & "    #""Tipo Alterado1"" = Table.TransformColumnTypes(#""Valor Substituído2"",{{""CGC"", type text}})," & Chr(10) & "    #""Linhas Classificadas"" = Table.Sort(#""Tipo Alterado1"",{{""ULTIMACOMPRA"", Order.Ascending}})" & _
"" & Chr(10) & "in" & Chr(10) & "    #""Linhas Classificadas"""
' ActiveWorkbook.Worksheets.Add
ActiveWorkbook.Connections("Consulta - meus-clientes").Refresh




Dim pathToXML As String


With Application.FileDialog(msoFileDialogFilePicker)
    .Filters.Clear


    .AllowMultiSelect = False
    .Filters.Add "XML", "*.xml"



    If .Show = -1 Then
        Dim clientes As ListObject

        pathToXML = .SelectedItems.Item(1)
        ' Worksheets(1).QueryTables(1).Connection = "XML;"& pathToXML

        ActiveWorkbook.Queries.Item("meus-clientes").Formula = _
        "Let" & Chr(10) & "    Fonte = Xml.Tables(File.Contents("& """" &pathToXML &"""" &"))," & Chr(10) & "    #""Tipo Alterado"" = Table.TransformColumnTypes(Fonte,{{""Attribute:Version"", Int64.Type}})," & Chr(10) & "    #""Colunas Removidas"" = Table.RemoveColumns(#""Tipo Alterado"",{""METADATA"", ""Attribute:Version""})," & Chr(10) & "    #""ROWDATA Expandido"" = Table.ExpandTableColumn(#" & _
        """Colunas Removidas"", ""ROWDATA"", {""ROW""}, {""ROWDATA.ROW""})," & Chr(10) & "    #""ROWDATA.ROW Expandido"" = Table.ExpandTableColumn(#""ROWDATA Expandido"", ""ROWDATA.ROW"", {""Attribute:SITUACAO"", ""Attribute:RAZAOSOCIAL"", ""Attribute:CIDADE"", ""Attribute:UF"", ""Attribute:CGC"", ""Attribute:ULTIMACOMPRA"", ""Attribute:FONE"", ""Attribute:EMAIL""}, {""ROWDATA.ROW.Attribu" & _
        "te:SITUACAO"", ""ROWDATA.ROW.Attribute:RAZAOSOCIAL"", ""ROWDATA.ROW.Attribute:CIDADE"", ""ROWDATA.ROW.Attribute:UF"", ""ROWDATA.ROW.Attribute:CGC"", ""ROWDATA.ROW.Attribute:ULTIMACOMPRA"", ""ROWDATA.ROW.Attribute:FONE"", ""ROWDATA.ROW.Attribute:EMAIL""})," & Chr(10) & "    #""Colunas Renomeadas"" = Table.RenameColumns(#""ROWDATA.ROW Expandido"",{{""ROWDATA.ROW.Attribute:CGC"", """ & _
        "CGC""}, {""ROWDATA.ROW.Attribute:UF"", ""UF""}, {""ROWDATA.ROW.Attribute:CIDADE"", ""CIDADE""}, {""ROWDATA.ROW.Attribute:RAZAOSOCIAL"", ""RAZAOSOCIAL""}, {""ROWDATA.ROW.Attribute:SITUACAO"", ""SITUACAO""}, {""ROWDATA.ROW.Attribute:ULTIMACOMPRA"", ""ULTIMACOMPRA""}, {""ROWDATA.ROW.Attribute:FONE"", ""FONE""}, {""ROWDATA.ROW.Attribute:EMAIL"", ""EMAIL""}})," & Chr(10) & "    #""Val" & _
        "Or SubstituíDo"" = Table.ReplaceValue(#""Colunas Renomeadas"",null,""n@o.tem"",Replacer.ReplaceValue,{""EMAIL""})," & Chr(10) & "    #""Valor Substituído1"" = Table.ReplaceValue(#""Valor SubstituíDo"",null,""(00) 00000-0000"",Replacer.ReplaceValue,{""FONE""})," & Chr(10) & "    #""Tipo Alterado com Localidade"" = Table.TransformColumnTypes(#""Valor Substituído1"", {{""ULTIMACOMPRA"", type date" & _
        "}}, ""pt-BR"")," & Chr(10) & "    #""Valor Substituído2"" = Table.ReplaceValue(#""Tipo Alterado com Localidade"",null,#date(1990, 1, 1),Replacer.ReplaceValue,{""ULTIMACOMPRA""})," & Chr(10) & "    #""Tipo Alterado1"" = Table.TransformColumnTypes(#""Valor Substituído2"",{{""CGC"", type text}})," & Chr(10) & "    #""Linhas Classificadas"" = Table.Sort(#""Tipo Alterado1"",{{""ULTIMACOMPRA"", Order.Ascending}})" & _
        "" & Chr(10) & "in" & Chr(10) & "    #""Linhas Classificadas"""
        ' ActiveWorkbook.Worksheets.Add
        ActiveWorkbook.Connections("Consulta - meus-clientes").Refresh
        MsgBox "Lista de Clientes Atualizada",,"Informe" 

    End If
End With