﻿using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Cloud.BookList.CloudBookLists.Books;
using Cloud.BookList.CloudBookLists.BookTags;

namespace Cloud.BookList.CloudBookLists.Relationships
{
    /// <summary>
    /// 书籍 关联 书籍标签
    /// </summary>
    public class BookAndBookTagRelationship : Entity<long>, IHasCreationTime, ICreationAudited, IModificationAudited, IMustHaveTenant
    {
        /// <summary>
        /// 书籍Id
        /// </summary>
        public long BookId { get; set; }

        public virtual Book Book { get; set; }



        /// <summary>
        /// 标签Id
        /// </summary>
        public long BookTagId { get; set; }

        public virtual BookTag BookTag { get; set; }



        public int TenantId { get; set; }

        public DateTime CreationTime { get; set; }

        public long? CreatorUserId { get; set; }

        public long? LastModifierUserId { get; set; }

        public DateTime? LastModificationTime { get; set; }
    }
}
