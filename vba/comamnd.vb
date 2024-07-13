Sub Macro6()
    '
    ' Macro6 Macro
    '

    '
    ActiveWorkbook.Queries.Add Name:="meus-clientes", Formula:= _
    "Let" & Chr(13) & "" & Chr(10) & "    Fonte = Xml.Tables(File.Contents(""D:\vendas11\Desktop\MAYCON\vendas-helps\vba\meus-clientes.xml""))," & Chr(13) & "" & Chr(10) & "    #""Tipo Alterado"" = Table.TransformColumnTypes(Fonte,{{""Attribute:Version"", Int64.Type}})," & Chr(13) & "" & Chr(10) & "    #""Colunas Removidas"" = Table.RemoveColumns(#""Tipo Alterado"",{""METADATA"", ""Attribute:Version""})," & Chr(13) & "" & Chr(10) & "    #""ROWDATA Expandido"" = Table.ExpandTable" & _
    "Column(#""Colunas Removidas"", ""ROWDATA"", {""ROW""}, {""ROWDATA.ROW""})," & Chr(13) & "" & Chr(10) & "    #""ROWDATA.ROW Expandido"" = Table.ExpandTableColumn(#""ROWDATA Expandido"", ""ROWDATA.ROW"", {""Attribute:SITUACAO"", ""Attribute:RAZAOSOCIAL"", ""Attribute:NOMEFANTASIA"", ""Attribute:ENDERECO"", ""Attribute:CIDADE"", ""Attribute:UF"", ""Attribute:VENDEDOR"", ""Attribute:CODAREA"", ""A" & _
    "ttribute:EXTERNO"", ""Attribute:CGC"", ""Attribute:CODSITFISCAL"", ""Attribute:CODIGO"", ""Attribute:IBGE"", ""Attribute:CODATIVIDADE"", ""Attribute:INATIVO"", ""Attribute:DATAATUALIZACAO"", ""Attribute:DATACADASTRO"", ""Attribute:ULTIMACOMPRA"", ""Attribute:VALOR_EM_ABERTO"", ""Attribute:FONE"", ""Attribute:EMAIL"", ""Attribute:EMAILNFE"", ""Attribute:LIMITECREDITO" & _
    """}, {""ROWDATA.ROW.Attribute:SITUACAO"", ""ROWDATA.ROW.Attribute:RAZAOSOCIAL"", ""ROWDATA.ROW.Attribute:NOMEFANTASIA"", ""ROWDATA.ROW.Attribute:ENDERECO"", ""ROWDATA.ROW.Attribute:CIDADE"", ""ROWDATA.ROW.Attribute:UF"", ""ROWDATA.ROW.Attribute:VENDEDOR"", ""ROWDATA.ROW.Attribute:CODAREA"", ""ROWDATA.ROW.Attribute:EXTERNO"", ""ROWDATA.ROW.Attribute:CGC"", ""ROWDATA." & _
    "ROW.Attribute:CODSITFISCAL"", ""ROWDATA.ROW.Attribute:CODIGO"", ""ROWDATA.ROW.Attribute:IBGE"", ""ROWDATA.ROW.Attribute:CODATIVIDADE"", ""ROWDATA.ROW.Attribute:INATIVO"", ""ROWDATA.ROW.Attribute:DATAATUALIZACAO"", ""ROWDATA.ROW.Attribute:DATACADASTRO"", ""ROWDATA.ROW.Attribute:ULTIMACOMPRA"", ""ROWDATA.ROW.Attribute:VALOR_EM_ABERTO"", ""ROWDATA.ROW.Attribute:FONE""," & _
    " ""ROWDATA.ROW.Attribute:EMAIL"", ""ROWDATA.ROW.Attribute:EMAILNFE"", ""ROWDATA.ROW.Attribute:LIMITECREDITO""})" & Chr(13) & "" & Chr(10) & "in" & Chr(13) & "" & Chr(10) & "    #""ROWDATA.ROW Expandido"""
    ' ActiveWorkbook.Worksheets.Add
    With ActiveSheet.ListObjects.Add(SourceType:=0, Source:= _
        "OLEDB;Provider=Microsoft.Mashup.OleDb.1;Data Source=$Workbook$;Location=clientes;Extended Properties=""""" _
        , Destination:=Range("$A$1")).QueryTable
        .CommandType = xlCmdSql
        .CommandText = Array("Select * FROM [meus-clientes]")
        .RowNumbers = False
        .FillAdjacentFormulas = False
        .PreserveFormatting = True
        .RefreshOnFileOpen = False
        .BackgroundQuery = True
        .RefreshStyle = xlInsertDeleteCells
        .SavePassword = False
        .SaveData = True
        .AdjustColumnWidth = True
        .RefreshPeriod = 0
        .PreserveColumnInfo = True
        .ListObject.DisplayName = "meus-clientes"
        .Refresh BackgroundQuery:=False
    End With
End Sub





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






Sub Macro1()
    '
    ' Macro1 Macro
    '

    '
    ActiveWorkbook.Queries.Add Name:="clientes-ph", Formula:= _
    "Let" & Chr(10) & "    Fonte = Xml.Tables(File.Contents(""D:\vendas11\Desktop\MAYCON\vendas-helps\vba\clientes-ph.xml""))," & Chr(10) & "    #""Tipo Alterado"" = Table.TransformColumnTypes(Fonte,{{""Attribute:Version"", Int64.Type}})," & Chr(10) & "    #""Colunas Removidas"" = Table.RemoveColumns(#""Tipo Alterado"",{""METADATA"", ""Attribute:Version""})," & Chr(10) & "    #""ROWDATA Expandido"" = Table.ExpandTableColumn(#" & _
    """Colunas Removidas"", ""ROWDATA"", {""ROW""}, {""ROWDATA.ROW""})," & Chr(10) & "    #""ROWDATA.ROW Expandido"" = Table.ExpandTableColumn(#""ROWDATA Expandido"", ""ROWDATA.ROW"", {""Attribute:SITUACAO"", ""Attribute:RAZAOSOCIAL"", ""Attribute:CIDADE"", ""Attribute:UF"", ""Attribute:CGC"", ""Attribute:ULTIMACOMPRA"", ""Attribute:FONE"", ""Attribute:EMAIL""}, {""ROWDATA.ROW.Attribu" & _
    "te:SITUACAO"", ""ROWDATA.ROW.Attribute:RAZAOSOCIAL"", ""ROWDATA.ROW.Attribute:CIDADE"", ""ROWDATA.ROW.Attribute:UF"", ""ROWDATA.ROW.Attribute:CGC"", ""ROWDATA.ROW.Attribute:ULTIMACOMPRA"", ""ROWDATA.ROW.Attribute:FONE"", ""ROWDATA.ROW.Attribute:EMAIL""})," & Chr(10) & "    #""Colunas Renomeadas"" = Table.RenameColumns(#""ROWDATA.ROW Expandido"",{{""ROWDATA.ROW.Attribute:CGC"", """ & _
    "CGC""}, {""ROWDATA.ROW.Attribute:UF"", ""UF""}, {""ROWDATA.ROW.Attribute:CIDADE"", ""CIDADE""}, {""ROWDATA.ROW.Attribute:RAZAOSOCIAL"", ""RAZAOSOCIAL""}, {""ROWDATA.ROW.Attribute:SITUACAO"", ""SITUACAO""}, {""ROWDATA.ROW.Attribute:ULTIMACOMPRA"", ""ULTIMACOMPRA""}, {""ROWDATA.ROW.Attribute:FONE"", ""FONE""}, {""ROWDATA.ROW.Attribute:EMAIL"", ""EMAIL""}})," & Chr(10) & "    #""Val" & _
    "Or SubstituíDo"" = Table.ReplaceValue(#""Colunas Renomeadas"",null,""n@o.tem"",Replacer.ReplaceValue,{""EMAIL""})," & Chr(10) & "    #""Valor Substituído1"" = Table.ReplaceValue(#""Valor SubstituíDo"",null,""(00) 00000-0000"",Replacer.ReplaceValue,{""FONE""})," & Chr(10) & "    #""Tipo Alterado com Localidade"" = Table.TransformColumnTypes(#""Valor Substituído1"", {{""ULTIMACOMPRA"", type date" & _
    "}}, ""pt-BR"")," & Chr(10) & "    #""Valor Substituído2"" = Table.ReplaceValue(#""Tipo Alterado com Localidade"",null,#date(1990, 1, 1),Replacer.ReplaceValue,{""ULTIMACOMPRA""})," & Chr(10) & "    #""Tipo Alterado1"" = Table.TransformColumnTypes(#""Valor Substituído2"",{{""CGC"", type text}})," & Chr(10) & "    #""Linhas Classificadas"" = Table.Sort(#""Tipo Alterado1"",{{""ULTIMACOMPRA"", Order.Ascending}})" & _
    "" & Chr(10) & "in" & Chr(10) & "    #""Linhas Classificadas"""
    ActiveWorkbook.Worksheets.Add
    With ActiveSheet.ListObjects.Add(SourceType:=0, Source:= _
        "OLEDB;Provider=Microsoft.Mashup.OleDb.1;Data Source=$Workbook$;Location=clientes-ph;Extended Properties=""""" _
        , Destination:=Range("$A$1")).QueryTable
        .CommandType = xlCmdSql
        .CommandText = Array("Select * FROM [clientes-ph]")
        .RowNumbers = False
        .FillAdjacentFormulas = False
        .PreserveFormatting = True
        .RefreshOnFileOpen = False
        .BackgroundQuery = True
        .RefreshStyle = xlInsertDeleteCells
        .SavePassword = False
        .SaveData = True
        .AdjustColumnWidth = True
        .RefreshPeriod = 0
        .PreserveColumnInfo = True
        .ListObject.DisplayName = "clientes_ph"
        .Refresh BackgroundQuery:=False
    End With
End Sub





' 

Sub Macro5()
    '
    ' Macro5 Macro
    '

    '
    Application.CutCopyMode = False
    Application.CutCopyMode = False
    ActiveWorkbook.Queries.Add Name:="minhas-vendas", Formula:= _
    "Let" & Chr(13) & "" & Chr(10) & "    Fonte = Xml.Tables(File.Contents(""D:\vendas11\Desktop\MAYCON\vendas-helps\vba\vendas-maycon.xml""))," & Chr(13) & "" & Chr(10) & "    #""Tipo Alterado"" = Table.TransformColumnTypes(Fonte,{{""Attribute:Version"", Int64.Type}})," & Chr(13) & "" & Chr(10) & "    #""Colunas Removidas"" = Table.RemoveColumns(#""Tipo Alterado"",{""METADATA"", ""Attribute:Version""})," & Chr(13) & "" & Chr(10) & "    #""ROWDATA Expandido"" = Table.ExpandTableCo" & _
    "lumn(#""Colunas Removidas"", ""ROWDATA"", {""ROW""}, {""ROWDATA.ROW""})," & Chr(13) & "" & Chr(10) & "    #""ROWDATA.ROW Expandido"" = Table.ExpandTableColumn(#""ROWDATA Expandido"", ""ROWDATA.ROW"", {""Attribute:SITUACAO"", ""Attribute:RAZAOSOCIAL"", ""Attribute:CIDADE"", ""Attribute:UF"", ""Attribute:VENDEDOR"", ""Attribute:EXTERNO"", ""Attribute:CGC"", ""Attribute:CODORCAMENTO"", ""Attribut" & _
    "e:DATA"", ""Attribute:NF"", ""Attribute:VENDEDOR_VENDA"", ""Attribute:TOTAL""}, {""ROWDATA.ROW.Attribute:SITUACAO"", ""ROWDATA.ROW.Attribute:RAZAOSOCIAL"", ""ROWDATA.ROW.Attribute:CIDADE"", ""ROWDATA.ROW.Attribute:UF"", ""ROWDATA.ROW.Attribute:VENDEDOR"", ""ROWDATA.ROW.Attribute:EXTERNO"", ""ROWDATA.ROW.Attribute:CGC"", ""ROWDATA.ROW.Attribute:CODORCAMENTO"", ""ROWD" & _
    "ATA.ROW.Attribute:DATA"", ""ROWDATA.ROW.Attribute:NF"", ""ROWDATA.ROW.Attribute:VENDEDOR_VENDA"", ""ROWDATA.ROW.Attribute:TOTAL""})," & Chr(13) & "" & Chr(10) & "    #""Colunas Renomeadas"" = Table.RenameColumns(#""ROWDATA.ROW Expandido"",{{""ROWDATA.ROW.Attribute:SITUACAO"", ""SITUACAO""}, {""ROWDATA.ROW.Attribute:RAZAOSOCIAL"", ""RAZAOSOCIAL""}, {""ROWDATA.ROW.Attribute:CIDADE"", ""CIDADE""}" & _
    ", {""ROWDATA.ROW.Attribute:UF"", ""UF""}, {""ROWDATA.ROW.Attribute:VENDEDOR"", ""VENDEDOR""}, {""ROWDATA.ROW.Attribute:EXTERNO"", ""EXTERNO""}, {""ROWDATA.ROW.Attribute:CGC"", ""CGC""}, {""ROWDATA.ROW.Attribute:CODORCAMENTO"", ""CODORCAMENTO""}, {""ROWDATA.ROW.Attribute:NF"", ""NF""}})," & Chr(13) & "" & Chr(10) & "    #""Colunas Removidas1"" = Table.RemoveColumns(#""Colunas Renomeadas"",{""RO" & _
    "WDATA.ROW.Attribute:VENDEDOR_VENDA""})," & Chr(13) & "" & Chr(10) & "    #""Colunas Renomeadas1"" = Table.RenameColumns(#""Colunas Removidas1"",{{""ROWDATA.ROW.Attribute:TOTAL"", ""TOTAL""}})," & Chr(13) & "" & Chr(10) & "    #""Valor SubstituíDo"" = Table.ReplaceValue(#""Colunas Renomeadas1"",""."","","",Replacer.ReplaceText,{""TOTAL""})," & Chr(13) & "" & Chr(10) & "    #""Tipo Alterado com Localidade"" = Table.TransformColumnTypes(#""Valor Subst" & _
    "ituíDo"", {{""TOTAL"", Currency.Type}}, ""pt-BR"")," & Chr(13) & "" & Chr(10) & "    #""Colunas Renomeadas2"" = Table.RenameColumns(#""Tipo Alterado com Localidade"",{{""ROWDATA.ROW.Attribute:DATA"", ""DATA""}})," & Chr(13) & "" & Chr(10) & "    #""Texto ExtraíDo Antes Do Delimitador"" = Table.TransformColumns(#""Colunas Renomeadas2"", {{""DATA"", each Text.BeforeDelimiter(_, ""T""), type text}})," & Chr(13) & "" & Chr(10) & "    #""Tipo Alterado c" & _
    "om Localidade1"" = Table.TransformColumnTypes(#""Texto ExtraíDo Antes Do Delimitador"", {{""DATA"", type date}}, ""pt-BR"")," & Chr(13) & "" & Chr(10) & "    #""Linhas Classificadas"" = Table.Sort(#""Tipo Alterado com Localidade1"",{{""DATA"", Order.Descending}})" & Chr(13) & "" & Chr(10) & "in" & Chr(13) & "" & Chr(10) & "    #""Linhas Classificadas"""
    Workbooks("VENDAS-CPL.xlsm").Connections.Add2 "Consulta - minhas-vendas", _
    "Conexão com a consulta 'minhas-vendas' na pasta de trabalho.", _
    "OLEDB;Provider=Microsoft.Mashup.OleDb.1;Data Source=$Workbook$;Location=minhas-vendas;Extended Properties=" _
    , """minhas-vendas""", 6, True, False
    With ActiveSheet.ListObjects.Add(SourceType:=4, Source:=ActiveWorkbook. _
        Connections("Consulta - minhas-vendas"), Destination:=Range("$A$1")). _
        TableObject
        .RowNumbers = False
        .PreserveFormatting = True
        .RefreshStyle = 1
        .AdjustColumnWidth = True
        .ListObject.DisplayName = "minhas_vendas"
        .Refresh
    End With
    ActiveSheet.ListObjects("minhas_vendas").TableStyle = "TableStyleMedium9"
    ActiveSheet.ListObjects("minhas_vendas").TableStyle = "TableStyleMedium9"
    With Selection.Font
        .Name = "Calibri"
        .Size = 14
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ThemeColor = xlThemeColorLight1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontMinor
    End With
    Rows("1:1").Select
    With Selection.Font
        .Name = "Calibri"
        .Size = 16
        .Strikethrough = False
        .Superscript = False
        .Subscript = False
        .OutlineFont = False
        .Shadow = False
        .Underline = xlUnderlineStyleNone
        .ThemeColor = xlThemeColorLight1
        .TintAndShade = 0
        .ThemeFont = xlThemeFontMinor
    End With
    Selection.Font.Bold = True
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    Columns("K:K").EntireColumn.AutoFit
    Columns("J:J").EntireColumn.AutoFit
    Columns("I:I").EntireColumn.AutoFit
    Columns("G:G").EntireColumn.AutoFit
    Columns("F:F").EntireColumn.AutoFit
    Columns("E:E").EntireColumn.AutoFit
    Columns("C:C").EntireColumn.AutoFit
    Columns("B:B").EntireColumn.AutoFit
    ActiveWindow.Zoom = 85
    Range("H32").Select
    ActiveWindow.SmallScroll Down:=-27
End Sub

