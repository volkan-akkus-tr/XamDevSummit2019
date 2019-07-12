// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace MSC.ConferenceMate.Repository.Entities.CM
{

    // Session_SessionCategoryType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class SessionSessionCategoryTypeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SessionSessionCategoryType>
    {
        public SessionSessionCategoryTypeConfiguration()
            : this("dbo")
        {
        }

        public SessionSessionCategoryTypeConfiguration(string schema)
        {
            ToTable("Session_SessionCategoryType", schema);
            HasKey(x => new { x.SessionId, x.SessionCategoryTypeId });

            Property(x => x.SessionId).HasColumnName(@"SessionId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SessionCategoryTypeId).HasColumnName(@"SessionCategoryTypeId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DataVersion).HasColumnName(@"DataVersion").HasColumnType("int").IsRequired();
            Property(x => x.CreatedUtcDate).HasColumnName(@"CreatedUtcDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.ModifiedUtcDate).HasColumnName(@"ModifiedUtcDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.ModifiedBy).HasColumnName(@"ModifiedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.Session).WithMany(b => b.SessionSessionCategoryTypes).HasForeignKey(c => c.SessionId).WillCascadeOnDelete(false); // FK_Session_SessionCategoryType_Session
            HasRequired(a => a.SessionCategoryType).WithMany(b => b.SessionSessionCategoryTypes).HasForeignKey(c => c.SessionCategoryTypeId).WillCascadeOnDelete(false); // FK_Session_SessionCategoryType_SessionCategoryType
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>