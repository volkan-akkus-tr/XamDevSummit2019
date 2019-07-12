// <auto-generated> - Template:ModelsBackedByDto, Version:1.1, Id:f1539c0d-024f-4b1f-b346-132cdd9dd31f
using CodeGenHero.Logging;
using CodeGenHero.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using MSC.ConferenceMate.API.Client.Interface;
using MSC.ConferenceMate.Model.CM.Interface;
using xDTO = MSC.ConferenceMate.DTO.CM;

namespace MSC.ConferenceMate.Model.CM
{

	public class LoadRequestBlobFile : EventArgs
	{
		public LoadRequestBlobFile(string propertyNameRequestingLoad)
		{
			PropertyNameRequestingLoad = propertyNameRequestingLoad;
		}

		public string PropertyNameRequestingLoad { get; set; }
	}


	public partial class BlobFile : BaseModel<IWebApiDataServiceCM>, IBlobFile
	{
		public event EventHandler<LoadRequestBlobFile> OnLazyLoadRequest = delegate { }; // Empty delegate. Thus we are sure that value is always != null because no one outside of the class can change it.
		private xDTO.BlobFile _dto = null;

		public BlobFile(ILoggingService log, IDataService<IWebApiDataServiceCM> dataService) : base(log, dataService)
		{
			_dto = new xDTO.BlobFile();
			OnLazyLoadRequest += HandleLazyLoadRequest;
		}

		public BlobFile(ILoggingService log, IDataService<IWebApiDataServiceCM> dataService, xDTO.BlobFile dto) : this(log, dataService)
		{
			_dto = dto;
		}


		public virtual System.Guid BlobFileId { get { return _dto.BlobFileId; } }
		public virtual int? BlobFileTypeId { get { return _dto.BlobFileTypeId; } }
		public virtual string BlobUri { get { return _dto.BlobUri; } }
		public virtual byte[] Content { get { return _dto.Content; } }
		public virtual string CreatedBy { get { return _dto.CreatedBy; } }
		public virtual System.DateTime CreatedUtcDate { get { return _dto.CreatedUtcDate; } }
		public virtual int DataVersion { get { return _dto.DataVersion; } }
		public virtual string DiscreteMimeType { get { return _dto.DiscreteMimeType; } }
		public virtual bool IsDeleted { get { return _dto.IsDeleted; } }
		public virtual string ModifiedBy { get { return _dto.ModifiedBy; } }
		public virtual System.DateTime ModifiedUtcDate { get { return _dto.ModifiedUtcDate; } }
		public virtual string Name { get { return _dto.Name; } }
		public virtual System.Guid? ParentBlobFileId { get { return _dto.ParentBlobFileId; } }
		public virtual bool? RequiresResize { get { return _dto.RequiresResize; } }
		public virtual bool? ResizeComplete { get { return _dto.ResizeComplete; } }
		public virtual long? SizeInBytes { get { return _dto.SizeInBytes; } }

		private IBlobFileType _blobFileType = null; // Foreign Key
		// Excluding 'UserProfiles' per configuration setting.


		public virtual IBlobFileType BlobFileType
		{
			get
			{
				if (_blobFileType == null && _dto != null && _dto.BlobFileType != null)
				{
					_blobFileType = new BlobFileType(Log, DataService, _dto.BlobFileType);
				}

				return _blobFileType;
			}
		}



	}
}