namespace Hel.Tiled.Utilities
{
    /// <summary>
    /// Helper class for handling tile GID data
    /// </summary>
    public static class TileHelper
    {
        public const uint FlippedHorizontallyFlag = 0x80000000;
        public const uint FlippedVerticallyFlag = 0x40000000;
        public const uint FlippedDiagonallyFlag = 0x20000000;
        
        public static bool IsFlippedHorizontally(int gid) => (gid & FlippedHorizontallyFlag) != 0;
        public static bool IsFlippedVertically(int gid) => (gid & FlippedVerticallyFlag) != 0;
        public static bool IsFlippedDiagonally(int gid) => (gid & FlippedDiagonallyFlag) != 0;

        /// <summary>
        /// Clean GID of all flags so it can be used. Uncleaned GID's containing flipped flags will not be usable for displaying
        /// tiles. This is due to the way Tiled saves a tiles flipped state.
        /// </summary>
        /// <param name="gid">the GID to clean</param>
        /// <returns>A clean GID that does not contain flags</returns>
        public static int CleanGid(int gid) 
            => gid &= (int) ~(FlippedHorizontallyFlag |
                                FlippedVerticallyFlag |
                                FlippedDiagonallyFlag);
        
    }
}