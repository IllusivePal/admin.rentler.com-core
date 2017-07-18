using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Rentler.Admin
{
    //[Serializable]
    public class JsonPagedList<T>
    {
        public JsonPagedList(PaginatedList<T> items)
        {
            this.Items = items;
        }

        public PaginatedList<T> Items { get; set; }

        /// <summary>
        /// Gets or sets the page number.
        /// </summary>
        /// <value>The index of the page.</value>
        public int PageNumber
        {
            get { return this.Items.PageNumber; }
        }

        /// <summary>
        /// Gets or sets the size of the page.
        /// </summary>
        /// <value>The size of the page.</value>
        public int PageSize
        {
            get { return this.Items.PageSize; }
        }

        /// <summary>
        /// Gets or sets the total count of items.
        /// </summary>
        /// <value>The total count.</value>
        public int TotalCount
        {
            get { return this.Items.TotalCount; }
        }

        /// <summary>
        /// Gets or sets the total pages.
        /// </summary>
        /// <value>The total pages.</value>
        public int TotalPages
        {
            get { return this.Items.TotalPages; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance has previous page.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance has previous page; otherwise, <c>false</c>.
        /// </value>
        public bool HasPreviousPage
        {
            get { return this.Items.HasPreviousPage; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance has next page.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance has next page; otherwise, <c>false</c>.
        /// </value>
        public bool HasNextPage
        {
            get { return this.Items.HasNextPage; }
        }

    }
}
