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