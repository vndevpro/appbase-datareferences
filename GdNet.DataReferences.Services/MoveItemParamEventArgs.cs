using System;
using GdNet.Common;

namespace GdNet.DataReferences.Services
{
    /// <summary>
    /// Move item in a list
    /// </summary>
    public class MoveItemParamEventArgs : EventArgs
    {
        /// <summary>
        /// Initialize all info to do a move
        /// </summary>
        /// <param name="referenceListId"></param>
        /// <param name="referenceItemId"></param>
        /// <param name="direction"></param>
        public MoveItemParamEventArgs(Guid referenceListId, Guid referenceItemId, Direction direction)
        {
            Direction = direction;
            ReferenceItemId = referenceItemId;
            ReferenceListId = referenceListId;
        }

        /// <summary>
        /// The RefList
        /// </summary>
        public Guid ReferenceListId { get; private set; }

        /// <summary>
        /// The RefItem
        /// </summary>
        public Guid ReferenceItemId { get; private set; }

        /// <summary>
        /// How to move
        /// </summary>
        public Direction Direction { get; private set; }
    }
}
