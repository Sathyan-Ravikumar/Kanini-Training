use sample
CREATE TABLE [dbo].[staff_Master](
	[Staff_Code] [int] NOT NULL,
	[Staff_Name] [nvarchar](50) NOT NULL,
	[Design_Code] [int] NULL,
	[Dept_Code] [int] NULL,
	[Staff_dob] [date] NULL,
	[Hiredate] [date] NULL,
	[Mgr_code] [int] NULL,
	[Staff_sal] [int] NULL,
	[Staff_address] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Staff_Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

select *from staff_Master;


select [dbo].[Staff_MasterNameDisplay](100,(select staff_sal from staff_master where staff_code=100001)) newsal;

use sample;
select * from Employee

select sc,sn,mgrna,mgrc from [dbo].[udf_StaffManager]()