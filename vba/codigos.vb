Let
Fonte = Xml.Tables(File.Contents("D:\vendas11\Desktop\MAYCON\VBA-testes\clientes-maycon.xml")),
#"Tipo Alterado" = Table.TransformColumnTypes(Fonte,{{"Attribute:Version", Int64.Type}}),
#"Colunas Removidas" = Table.RemoveColumns(#"Tipo Alterado",{"METADATA", "Attribute:Version"}),
#"ROWDATA Expandido" = Table.ExpandTableColumn(#"Colunas Removidas", "ROWDATA", {"ROW"}, {"ROWDATA.ROW"}),
#"ROWDATA.ROW Expandido" = Table.ExpandTableColumn(#"ROWDATA Expandido", "ROWDATA.ROW", {"Attribute:SITUACAO", "Attribute:RAZAOSOCIAL", "Attribute:CIDADE", "Attribute:UF", "Attribute:CGC", "Attribute:ULTIMACOMPRA", "Attribute:FONE", "Attribute:EMAIL"}, {"ROWDATA.ROW.Attribute:SITUACAO", "ROWDATA.ROW.Attribute:RAZAOSOCIAL", "ROWDATA.ROW.Attribute:CIDADE", "ROWDATA.ROW.Attribute:UF", "ROWDATA.ROW.Attribute:CGC", "ROWDATA.ROW.Attribute:ULTIMACOMPRA", "ROWDATA.ROW.Attribute:FONE", "ROWDATA.ROW.Attribute:EMAIL"}),
#"Colunas Renomeadas" = Table.RenameColumns(#"ROWDATA.ROW Expandido",{{"ROWDATA.ROW.Attribute:CGC", "CGC"}, {"ROWDATA.ROW.Attribute:UF", "UF"}, {"ROWDATA.ROW.Attribute:CIDADE", "CIDADE"}, {"ROWDATA.ROW.Attribute:RAZAOSOCIAL", "RAZAOSOCIAL"}, {"ROWDATA.ROW.Attribute:SITUACAO", "SITUACAO"}, {"ROWDATA.ROW.Attribute:ULTIMACOMPRA", "ULTIMACOMPRA"}, {"ROWDATA.ROW.Attribute:FONE", "FONE"}, {"ROWDATA.ROW.Attribute:EMAIL", "EMAIL"}}),
#"Valor SubstituíDo" = Table.ReplaceValue(#"Colunas Renomeadas",null,"n@o.tem",Replacer.ReplaceValue,{"EMAIL"}),
#"Valor Substituído1" = Table.ReplaceValue(#"Valor SubstituíDo",null,"(00) 00000-0000",Replacer.ReplaceValue,{"FONE"}),
#"Tipo Alterado com Localidade" = Table.TransformColumnTypes(#"Valor Substituído1", {{"ULTIMACOMPRA", type date}}, "pt-BR"),
#"Valor Substituído2" = Table.ReplaceValue(#"Tipo Alterado com Localidade",null,#date(1990, 1, 1),Replacer.ReplaceValue,{"ULTIMACOMPRA"}),
#"Tipo Alterado1" = Table.TransformColumnTypes(#"Valor Substituído2",{{"CGC", type text}})
in
#"Tipo Alterado1"