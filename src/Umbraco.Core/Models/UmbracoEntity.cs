﻿using System;
using System.Reflection;
using Umbraco.Core.Models.EntityBase;

namespace Umbraco.Core.Models
{
    /// <summary>
    /// Implementation of the <see cref="IUmbracoEntity"/> for internal use.
    /// </summary>
    internal class UmbracoEntity : Entity, IUmbracoEntity
    {
        private int _creatorId;
        private int _level;
        private string _name;
        private int _parentId;
        private string _path;
        private int _sortOrder;
        private bool _trashed;
        private bool _hasChildren;
        private bool _isPublished;
        private bool _isDraft;
        private bool _hasPendingChanges;
        private string _contentTypeAlias;
        private string _umbracoFile;
        private Guid _nodeObjectTypeId;

        private static readonly PropertyInfo CreatorIdSelector = ExpressionHelper.GetPropertyInfo<UmbracoEntity, int>(x => x.CreatorId);
        private static readonly PropertyInfo LevelSelector = ExpressionHelper.GetPropertyInfo<UmbracoEntity, int>(x => x.Level);
        private static readonly PropertyInfo NameSelector = ExpressionHelper.GetPropertyInfo<UmbracoEntity, string>(x => x.Name);
        private static readonly PropertyInfo ParentIdSelector = ExpressionHelper.GetPropertyInfo<UmbracoEntity, int>(x => x.ParentId);
        private static readonly PropertyInfo PathSelector = ExpressionHelper.GetPropertyInfo<UmbracoEntity, string>(x => x.Path);
        private static readonly PropertyInfo SortOrderSelector = ExpressionHelper.GetPropertyInfo<UmbracoEntity, int>(x => x.SortOrder);
        private static readonly PropertyInfo TrashedSelector = ExpressionHelper.GetPropertyInfo<UmbracoEntity, bool>(x => x.Trashed);
        private static readonly PropertyInfo HasChildrenSelector = ExpressionHelper.GetPropertyInfo<UmbracoEntity, bool>(x => x.HasChildren);
        private static readonly PropertyInfo IsPublishedSelector = ExpressionHelper.GetPropertyInfo<UmbracoEntity, bool>(x => x.IsPublished);
        private static readonly PropertyInfo IsDraftSelector = ExpressionHelper.GetPropertyInfo<UmbracoEntity, bool>(x => x.IsDraft);
        private static readonly PropertyInfo HasPendingChangesSelector = ExpressionHelper.GetPropertyInfo<UmbracoEntity, bool>(x => x.HasPendingChanges);
        private static readonly PropertyInfo ContentTypeAliasSelector = ExpressionHelper.GetPropertyInfo<UmbracoEntity, string>(x => x.ContentTypeAlias);
        private static readonly PropertyInfo ContentTypeIconUrlSelector = ExpressionHelper.GetPropertyInfo<UmbracoEntity, string>(x => x.ContentTypeIcon);
        private static readonly PropertyInfo UmbracoFileSelector = ExpressionHelper.GetPropertyInfo<UmbracoEntity, string>(x => x.UmbracoFile);
        private static readonly PropertyInfo NodeObjectTypeIdSelector = ExpressionHelper.GetPropertyInfo<UmbracoEntity, Guid>(x => x.NodeObjectTypeId);
        private string _contentTypeIcon;

        public UmbracoEntity()
        {
        }

        public UmbracoEntity(bool trashed)
        {
            Trashed = trashed;
        }

        public int CreatorId
        {
            get { return _creatorId; }
            set
            {
                SetPropertyValueAndDetectChanges(o =>
                {
                    _creatorId = value;
                    return _creatorId;
                }, _creatorId, CreatorIdSelector);  
            }
        }

        public int Level
        {
            get { return _level; }
            set
            {
                SetPropertyValueAndDetectChanges(o =>
                {
                    _level = value;
                    return _level;
                }, _level, LevelSelector);  
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                SetPropertyValueAndDetectChanges(o =>
                {
                    _name = value;
                    return _name;
                }, _name, NameSelector);  
            }
        }

        public int ParentId
        {
            get { return _parentId; }
            set
            {
                SetPropertyValueAndDetectChanges(o =>
                {
                    _parentId = value;
                    return _parentId;
                }, _parentId, ParentIdSelector);  
            }
        }

        public string Path
        {
            get { return _path; }
            set
            {
                SetPropertyValueAndDetectChanges(o =>
                {
                    _path = value;
                    return _path;
                }, _path, PathSelector);  
            }
        }

        public int SortOrder
        {
            get { return _sortOrder; }
            set
            {
                SetPropertyValueAndDetectChanges(o =>
                {
                    _sortOrder = value;
                    return _sortOrder;
                }, _sortOrder, SortOrderSelector);  
            }
        }

        public bool Trashed
        {
            get { return _trashed; }
            private set
            {
                SetPropertyValueAndDetectChanges(o =>
                {
                    _trashed = value;
                    return _trashed;
                }, _trashed, TrashedSelector);  
            }
        }

        public bool HasChildren
        {
            get { return _hasChildren; }
            set
            {
                SetPropertyValueAndDetectChanges(o =>
                {
                    _hasChildren = value;
                    return _hasChildren;
                }, _hasChildren, HasChildrenSelector);  
            }
        }

        public bool IsPublished
        {
            get { return _isPublished; }
            set
            {
                SetPropertyValueAndDetectChanges(o =>
                {
                    _isPublished = value;
                    return _isPublished;
                }, _isPublished, IsPublishedSelector);  
            }
        }

        public bool IsDraft
        {
            get { return _isPublished; }
            set
            {
                SetPropertyValueAndDetectChanges(o =>
                {
                    _isDraft = value;
                    return _isDraft;
                }, _isDraft, IsDraftSelector);
            }
        }

        public bool HasPendingChanges
        {
            get { return _hasPendingChanges; }
            set
            {
                SetPropertyValueAndDetectChanges(o =>
                {
                    _hasPendingChanges = value;
                    return _hasPendingChanges;
                }, _hasPendingChanges, HasPendingChangesSelector);
            }
        }

        public string ContentTypeAlias
        {
            get { return _contentTypeAlias; }
            set
            {
                SetPropertyValueAndDetectChanges(o =>
                {
                    _contentTypeAlias = value;
                    return _contentTypeAlias;
                }, _contentTypeAlias, ContentTypeAliasSelector);
            }
        }

        public string ContentTypeIcon
        {
            get { return _contentTypeIcon; }
            set
            {
                SetPropertyValueAndDetectChanges(o =>
                {
                    _contentTypeIcon = value;
                    return _contentTypeIcon;
                }, _contentTypeIcon, ContentTypeIconUrlSelector);
            }
        }

        public string UmbracoFile
        {
            get { return _umbracoFile; }
            set
            {
                SetPropertyValueAndDetectChanges(o =>
                {
                    _umbracoFile = value;
                    return _umbracoFile;
                }, _umbracoFile, UmbracoFileSelector);
            }
        }

        public Guid NodeObjectTypeId
        {
            get { return _nodeObjectTypeId; }
            set
            {
                SetPropertyValueAndDetectChanges(o =>
                {
                    _nodeObjectTypeId = value;
                    return _nodeObjectTypeId;
                }, _nodeObjectTypeId, NodeObjectTypeIdSelector);  
            }
        }
    }
}