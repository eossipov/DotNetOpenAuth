﻿ALTER TABLE [dbo].[OpenIDAssociation]
    ADD CONSTRAINT [PK_OpenIDAssociations] PRIMARY KEY CLUSTERED ([AssociationId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
