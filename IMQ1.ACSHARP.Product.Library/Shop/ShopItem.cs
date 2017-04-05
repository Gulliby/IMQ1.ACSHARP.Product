using System;

namespace IMQ1.ACSHARP.Product.Library.Shop
{
    /// <summary>
    /// The entity that is responsible for storing information about the product.
    /// </summary>
    /// <seealso cref="System.IEquatable{ShopItem}" />
    public struct ShopItem : IEquatable<ShopItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopItem"/> struct.
        /// </summary>
        /// <param name="name">Name of the product.</param>
        /// <param name="cost">Cost of the product.</param>
        /// <param name="count">Quantity of products.</param>
        public ShopItem(string name, int cost, int count)
        {
            Name = name;
            Cost = cost;
            Count = count;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; }

        /// <summary>
        /// Gets the cost.
        /// </summary>
        /// <value>
        /// The cost.
        /// </value>
        public int Cost { get; }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count { get; }

        /// <summary>
        /// Determines whether the specified <see cref="object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is ShopItem)
            {
                var si = (ShopItem)obj;
                return Equals(si);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(ShopItem other)
        {
            return Name == other.Name &&
                   Cost == other.Cost &&
                   Count == other.Count;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            return string
                   .Format("{0} {1} {2}", Name, Cost, Count)
                   .GetHashCode();
        }
    }
}
