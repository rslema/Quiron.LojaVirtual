USE [Quiron]

GO



/****** Object:  View [dbo].[ClubesNacionais]    Script Date: 20/09/2015 09:55:04 ******/

SET ANSI_NULLS ON

GO



SET QUOTED_IDENTIFIER ON

GO



CREATE VIEW [dbo].[ClubesNacionais]

AS

SELECT        LinhaCodigo, LinhaDescricao

FROM            dbo.Linha

WHERE        (LinhaCodigo IN (0002, 0151, 0006, 0017, 0115, 0257, 0023, 0025, 0303, 0189, 0033, 0012, 0152, 0293, 0305, 0129, 0357))



GO


USE [Quiron]

GO



/****** Object:  View [dbo].[ClubesInternacionais]    Script Date: 17/09/2015 08:58:22 ******/

SET ANSI_NULLS ON

GO



SET QUOTED_IDENTIFIER ON

GO



CREATE VIEW [dbo].[ClubesInternacionais]

AS

SELECT        LinhaCodigo, LinhaDescricao

FROM            dbo.Linha

WHERE        (LinhaCodigo IN (0130, 1388, 0188, 0147, 0016, 0241, 0198, 0124, 0008, 0210, 0779, 1388, 1474))



GO