CREATE TABLE [dbo].[Inchiriere] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [Magazin]  NVARCHAR (MAX) NOT NULL,
    [Locatie]  NVARCHAR (MAX) NOT NULL,
    [Contact]  NVARCHAR (MAX) NOT NULL,
    [PartieID] INT            NOT NULL,
    CONSTRAINT [PK_Inchiriere] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Inchiriere_Partie_PartieID] FOREIGN KEY ([PartieID]) REFERENCES [dbo].[Partie] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Inchiriere_PartieID]
    ON [dbo].[Inchiriere]([PartieID] ASC);

