﻿using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Cloud.BookList.CloudBookLists.Books;

namespace Cloud.BookList.CloudBookLists.Relationships
{
    /// <summary>
    /// 书单 关联 书籍
    /// </summary>
    public class BookListAndBookRelationship : Entity<long>, IHasCreationTime, ICreationAudited, IModificationAudited, IMustHaveTenant
    {

        /// <summary>
        /// 书单Id
        /// </summary>
        public long BookListId { get; set; }

        public virtual BookLists.BookList BookList { get; set; }



        /// <summary>
        /// 书籍Id
        /// </summary>
        public long BookId { get; set; }

        public virtual Book Book { get; set; }





        public int TenantId { get; set; }

        public DateTime CreationTime { get; set; }

        public long? CreatorUserId { get; set; }

        public long? LastModifierUserId { get; set; }

        public DateTime? LastModificationTime { get; set; }
    }
}
