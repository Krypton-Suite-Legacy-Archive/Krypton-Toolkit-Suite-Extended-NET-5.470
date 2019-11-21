#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.Collections;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.ListBox
{
    /// <summary>
    /// A very simple implementation of a cache for a limited number
    /// of objects. 
    /// </summary>
    public class FixedSizeCache
    {
        private const int DEFAULT_CACHE_CAPACITY = 200;

        private int size;
        private Hashtable cache;
        private Queue keyHistory;

        public void Add(object key, object item)
        {
            if (cache.Contains(key))
            {
                // this item may end up being removed inappropriately
                // early, since we haven't adjusted the keyHistory
                // queue.  The assumption is that it is
                // quicker to do an additional lookup than rewrite
                // the keyHistory queue.
                cache[key] = item;
            }
            else
            {
                keyHistory.Enqueue(key);
                cache.Add(key, item);
                if (cache.Count > size)
                {
                    // remove oldest item
                    object removeKey = keyHistory.Dequeue();
                    cache.Remove(removeKey);
                }
            }
        }

        public void Clear()
        {
            cache.Clear();
            keyHistory.Clear();
        }

        public bool Contains(object key)
        {
            return cache.Contains(key);
        }

        public object this[object key]
        {
            get
            {
                return cache[key];
            }
        }

        public FixedSizeCache(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Cache capacity must be >= 1", "capacity");
            }
            size = capacity;
            cache = new Hashtable();
            keyHistory = new Queue();
        }

        public FixedSizeCache() : this(DEFAULT_CACHE_CAPACITY)
        {
        }
    }
}