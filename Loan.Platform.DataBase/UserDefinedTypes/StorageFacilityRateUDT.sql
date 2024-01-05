﻿CREATE Type [dbo].[StorageFacilityRateUDT] as Table(
	[Id] [bigint] NULL,
	[StorageFacilityId] [bigint] NULL,
	[StorageFacilityName] [nvarchar](100) NULL,
	[CurrencyId] [smallint] NULL,
	[DailyStorageRate] [decimal](18, 2) NULL,
	[SwitchIn] [decimal](18, 2) NULL,
	[SwitchOut] [decimal](18, 2) NULL,
	[SwitchingRate] [decimal](18, 2) NULL,
	[SpecialSwitchingRate] [decimal](18, 2) NULL,
	[HazmatSwitchInRate] [decimal](18, 2) NULL,
	[HazmatSwitchOutRate] [decimal](18, 2) NULL,
	[LoadedSwitchInRate] [decimal](18, 2) NULL,
	[LoadedSwitchOutRate] [decimal](18, 2) NULL,
	[CherryPickingRate] [decimal](18, 2) NULL,
	[ReservationRate] [decimal](18, 2) NULL,
	[EffectiveDate] [datetime2](7) NULL,
	[ExpiryDate] [datetime2](7) NULL,
	[CreatedTime] [datetime2](7) NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedTime] [datetime2](7) NULL,
	[ModifiedBy] [bigint] NULL,
	[OrganizationId] [bigint] NULL,
	[TenantId] [bigint] NULL,
	[IsActive] [bit] NULL
	)