﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using AutoRest.Core.Model;
using Newtonsoft.Json;

namespace AutoRest.Core.Utilities.Collections
{
    [JsonObject(IsReference = true)]
    public class ListEx<T> : IEnumerableWithIndex<T>, ICopyFrom<IEnumerable<T>>
    {
        private readonly List<T> _list = new List<T>();

        public ListEx()
        {
            // set AddMethod manually.
        }

        public Func<T, T> AddMethod { get; set; }

        public bool CopyFrom(IEnumerable<T> source)
        {
            if (source == null)
            {
                return false;
            }

            foreach (var item in source)
            {
                AddMethod(item);
            }
            return true;
        }

        public virtual IEnumerator<T> GetEnumerator() => _list.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public virtual int Count => _list.Count;

        public virtual T this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }

        public bool CopyFrom(object source)
        {
            return CopyFrom(source as IEnumerable<T>);
        }

        public virtual T Add(T item)
        {
            if (!_list.Contains(item))
            {
                _list.Add(item);
            }
            return item;
        }

        public virtual bool Contains(T item) => _list.Contains(item);

        public virtual bool Remove(T item) => _list.Remove(item);

        public virtual T Insert(int index, T item)
        {
            _list.Insert(index, item);
            return item;
        }
    }
}