USE [SrodkiTrwale]
GO
/****** Object:  Table [dbo].[Amortyzacja]    Script Date: 18.04.2020 19:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Amortyzacja](
	[NrInwentarzowy] [int] NOT NULL,
	[DataRozpAmortyzacji] [date] NOT NULL,
	[WartoscPoczatkowa] [money] NOT NULL,
	[StawkaAmortyzacji] [float] NOT NULL,
	[WspolczynnikAmortyzacji] [float] NOT NULL,
	[MetodaAmortyzacji] [nchar](50) NOT NULL,
	[WartoscBiezaca] [money] NULL,
 CONSTRAINT [PK_Amortyzacja] PRIMARY KEY CLUSTERED 
(
	[NrInwentarzowy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dokument]    Script Date: 18.04.2020 19:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dokument](
	[NrDokumentu] [nchar](20) NOT NULL,
	[Data] [date] NOT NULL,
	[Kwota] [money] NOT NULL,
	[Opis] [nvarchar](500) NULL,
 CONSTRAINT [PK_Dokument] PRIMARY KEY CLUSTERED 
(
	[NrDokumentu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kategoria]    Script Date: 18.04.2020 19:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategoria](
	[NazwaKategorii] [nchar](40) NOT NULL,
	[OpisKategorii] [nchar](200) NOT NULL,
 CONSTRAINT [PK_Kategoria] PRIMARY KEY CLUSTERED 
(
	[NazwaKategorii] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KST]    Script Date: 18.04.2020 19:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KST](
	[Numer] [int] NOT NULL,
	[Grupa] [int] NOT NULL,
	[Podgrupa] [int] NOT NULL,
	[Rodzaj] [int] NOT NULL,
	[Opis] [nchar](255) NULL,
 CONSTRAINT [PK_KST] PRIMARY KEY CLUSTERED 
(
	[Numer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MetodyAmortyzacji]    Script Date: 18.04.2020 19:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetodyAmortyzacji](
	[NazwaMetody] [nchar](50) NOT NULL,
	[OpisMetody] [nchar](255) NOT NULL,
 CONSTRAINT [PK_MetodyAmortyzacji] PRIMARY KEY CLUSTERED 
(
	[NazwaMetody] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pracownik]    Script Date: 18.04.2020 19:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pracownik](
	[IdPracownika] [int] IDENTITY(1,1) NOT NULL,
	[Nazwisko] [nchar](50) NOT NULL,
	[Imie] [nchar](50) NOT NULL,
	[DataUr] [date] NULL,
	[PESEL] [nchar](11) NOT NULL,
 CONSTRAINT [PK_Pracownik] PRIMARY KEY CLUSTERED 
(
	[IdPracownika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sezonowosc]    Script Date: 18.04.2020 19:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sezonowosc](
	[NrInwentarzowy] [int] NOT NULL,
	[Styczen] [bit] NULL,
	[Luty] [bit] NULL,
	[Marzec] [bit] NULL,
	[Kwiecien] [bit] NULL,
	[Maj] [bit] NULL,
	[Czerwiec] [bit] NULL,
	[Lipiec] [bit] NULL,
	[Sierpien] [bit] NULL,
	[Wrzesien] [bit] NULL,
	[Pazdziernik] [bit] NULL,
	[Listopad] [bit] NULL,
	[Grudzien] [bit] NULL,
 CONSTRAINT [PK_Sezonowosc] PRIMARY KEY CLUSTERED 
(
	[NrInwentarzowy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SrodekTrwaly]    Script Date: 18.04.2020 19:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SrodekTrwaly](
	[NazwaSrodka] [nvarchar](50) NOT NULL,
	[NrInwentarzowy] [int] IDENTITY(1,1) NOT NULL,
	[KST] [int] NULL,
	[OsosbaOdp] [int] NULL,
	[MiejsceUzytkowania] [nvarchar](150) NULL,
	[DataZakupu] [date] NOT NULL,
	[DataLikwidacji] [date] NULL,
	[Stan] [nchar](30) NULL,
	[PrzyczynaZbycia] [nvarchar](255) NULL,
	[Kategoria] [nchar](40) NULL,
	[Dokument] [nchar](20) NULL,
 CONSTRAINT [PK_SrodekTrwaly] PRIMARY KEY CLUSTERED 
(
	[NrInwentarzowy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Amortyzacja] ([NrInwentarzowy], [DataRozpAmortyzacji], [WartoscPoczatkowa], [StawkaAmortyzacji], [WspolczynnikAmortyzacji], [MetodaAmortyzacji], [WartoscBiezaca]) VALUES (2003, CAST(N'2020-04-18' AS Date), 5000.0000, 1, 2.5, N'Jednorazowa                                       ', NULL)
INSERT [dbo].[Amortyzacja] ([NrInwentarzowy], [DataRozpAmortyzacji], [WartoscPoczatkowa], [StawkaAmortyzacji], [WspolczynnikAmortyzacji], [MetodaAmortyzacji], [WartoscBiezaca]) VALUES (2004, CAST(N'2020-04-12' AS Date), 30000.0000, 1, 3, N'Degresywna                                        ', NULL)
INSERT [dbo].[Dokument] ([NrDokumentu], [Data], [Kwota], [Opis]) VALUES (N'C5634               ', CAST(N'2020-04-17' AS Date), 123.1200, N'Przedmiot2')
INSERT [dbo].[Dokument] ([NrDokumentu], [Data], [Kwota], [Opis]) VALUES (N'IE1334              ', CAST(N'2020-04-17' AS Date), 1200.5400, N'Przedmiot')
INSERT [dbo].[Dokument] ([NrDokumentu], [Data], [Kwota], [Opis]) VALUES (N'P5643               ', CAST(N'2020-04-17' AS Date), 1500.5000, N'Przedmiot3')
INSERT [dbo].[Kategoria] ([NazwaKategorii], [OpisKategorii]) VALUES (N'Kategoria Druga                         ', N'Opis kategorii drugiej                                                                                                                                                                                  ')
INSERT [dbo].[Kategoria] ([NazwaKategorii], [OpisKategorii]) VALUES (N'KateogiraPierwsza                       ', N'Opis kategorii pierwszej                                                                                                                                                                                ')
INSERT [dbo].[KST] ([Numer], [Grupa], [Podgrupa], [Rodzaj], [Opis]) VALUES (123, 1, 2, 3, N'budynek                                                                                                                                                                                                                                                        ')
INSERT [dbo].[KST] ([Numer], [Grupa], [Podgrupa], [Rodzaj], [Opis]) VALUES (321, 3, 2, 1, N'komputer                                                                                                                                                                                                                                                       ')
INSERT [dbo].[KST] ([Numer], [Grupa], [Podgrupa], [Rodzaj], [Opis]) VALUES (532, 5, 3, 2, N'samochód                                                                                                                                                                                                                                                       ')
INSERT [dbo].[MetodyAmortyzacji] ([NazwaMetody], [OpisMetody]) VALUES (N'Degresywna                                        ', N'Degresywna                                                                                                                                                                                                                                                     ')
INSERT [dbo].[MetodyAmortyzacji] ([NazwaMetody], [OpisMetody]) VALUES (N'Jednorazowa                                       ', N'Jednorazowa                                                                                                                                                                                                                                                    ')
INSERT [dbo].[MetodyAmortyzacji] ([NazwaMetody], [OpisMetody]) VALUES (N'Liniowa                                           ', N'Liniowa                                                                                                                                                                                                                                                        ')
INSERT [dbo].[MetodyAmortyzacji] ([NazwaMetody], [OpisMetody]) VALUES (N'Naturalna                                         ', N'Naturalna                                                                                                                                                                                                                                                      ')
SET IDENTITY_INSERT [dbo].[Pracownik] ON 

INSERT [dbo].[Pracownik] ([IdPracownika], [Nazwisko], [Imie], [DataUr], [PESEL]) VALUES (14, N'Kowal                                             ', N'Jan                                               ', CAST(N'2000-04-17' AS Date), N'12345678901')
INSERT [dbo].[Pracownik] ([IdPracownika], [Nazwisko], [Imie], [DataUr], [PESEL]) VALUES (15, N'Boba                                              ', N'Andrzej                                           ', CAST(N'1998-04-17' AS Date), N'98989898989')
SET IDENTITY_INSERT [dbo].[Pracownik] OFF
INSERT [dbo].[Sezonowosc] ([NrInwentarzowy], [Styczen], [Luty], [Marzec], [Kwiecien], [Maj], [Czerwiec], [Lipiec], [Sierpien], [Wrzesien], [Pazdziernik], [Listopad], [Grudzien]) VALUES (2003, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1)
INSERT [dbo].[Sezonowosc] ([NrInwentarzowy], [Styczen], [Luty], [Marzec], [Kwiecien], [Maj], [Czerwiec], [Lipiec], [Sierpien], [Wrzesien], [Pazdziernik], [Listopad], [Grudzien]) VALUES (2004, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[SrodekTrwaly] ON 

INSERT [dbo].[SrodekTrwaly] ([NazwaSrodka], [NrInwentarzowy], [KST], [OsosbaOdp], [MiejsceUzytkowania], [DataZakupu], [DataLikwidacji], [Stan], [PrzyczynaZbycia], [Kategoria], [Dokument]) VALUES (N'Komputer', 2003, 321, 14, N'Biuro', CAST(N'2020-04-12' AS Date), CAST(N'2020-04-16' AS Date), N'Zlikwidowany                  ', N'', N'KateogiraPierwsza                       ', N'IE1334              ')
INSERT [dbo].[SrodekTrwaly] ([NazwaSrodka], [NrInwentarzowy], [KST], [OsosbaOdp], [MiejsceUzytkowania], [DataZakupu], [DataLikwidacji], [Stan], [PrzyczynaZbycia], [Kategoria], [Dokument]) VALUES (N'Samochód', 2004, 123, 15, N'Budynek 2', CAST(N'2020-04-12' AS Date), CAST(N'2020-04-13' AS Date), N'Zbyty                         ', N'Sprzedany', N'Kategoria Druga                         ', N'C5634               ')
SET IDENTITY_INSERT [dbo].[SrodekTrwaly] OFF
ALTER TABLE [dbo].[Amortyzacja]  WITH CHECK ADD  CONSTRAINT [FK_Amortyzacja_MetodyAmortyzacji] FOREIGN KEY([MetodaAmortyzacji])
REFERENCES [dbo].[MetodyAmortyzacji] ([NazwaMetody])
GO
ALTER TABLE [dbo].[Amortyzacja] CHECK CONSTRAINT [FK_Amortyzacja_MetodyAmortyzacji]
GO
ALTER TABLE [dbo].[Amortyzacja]  WITH CHECK ADD  CONSTRAINT [FK_Amortyzacja_Sezonowosc] FOREIGN KEY([NrInwentarzowy])
REFERENCES [dbo].[Sezonowosc] ([NrInwentarzowy])
GO
ALTER TABLE [dbo].[Amortyzacja] CHECK CONSTRAINT [FK_Amortyzacja_Sezonowosc]
GO
ALTER TABLE [dbo].[Amortyzacja]  WITH CHECK ADD  CONSTRAINT [FK_Amortyzacja_SrodekTrwaly] FOREIGN KEY([NrInwentarzowy])
REFERENCES [dbo].[SrodekTrwaly] ([NrInwentarzowy])
GO
ALTER TABLE [dbo].[Amortyzacja] CHECK CONSTRAINT [FK_Amortyzacja_SrodekTrwaly]
GO
ALTER TABLE [dbo].[SrodekTrwaly]  WITH CHECK ADD  CONSTRAINT [FK_SrodekTrwaly_Dokument] FOREIGN KEY([Dokument])
REFERENCES [dbo].[Dokument] ([NrDokumentu])
GO
ALTER TABLE [dbo].[SrodekTrwaly] CHECK CONSTRAINT [FK_SrodekTrwaly_Dokument]
GO
ALTER TABLE [dbo].[SrodekTrwaly]  WITH CHECK ADD  CONSTRAINT [FK_SrodekTrwaly_Kategoria] FOREIGN KEY([Kategoria])
REFERENCES [dbo].[Kategoria] ([NazwaKategorii])
GO
ALTER TABLE [dbo].[SrodekTrwaly] CHECK CONSTRAINT [FK_SrodekTrwaly_Kategoria]
GO
ALTER TABLE [dbo].[SrodekTrwaly]  WITH CHECK ADD  CONSTRAINT [FK_SrodekTrwaly_KST] FOREIGN KEY([KST])
REFERENCES [dbo].[KST] ([Numer])
GO
ALTER TABLE [dbo].[SrodekTrwaly] CHECK CONSTRAINT [FK_SrodekTrwaly_KST]
GO
ALTER TABLE [dbo].[SrodekTrwaly]  WITH CHECK ADD  CONSTRAINT [FK_SrodekTrwaly_Pracownik] FOREIGN KEY([OsosbaOdp])
REFERENCES [dbo].[Pracownik] ([IdPracownika])
GO
ALTER TABLE [dbo].[SrodekTrwaly] CHECK CONSTRAINT [FK_SrodekTrwaly_Pracownik]
GO
