namespace Bakery.BuildingBlocks.Common;

public static class IdentityGenerator
{
    /// <summary>
    /// Create new sequential Guid
    /// source: https://github.com/dotnet/runtime/issues/22721
    /// </summary>
    /// <returns>Guid</returns>
    public static Guid NewSequencialGuid()
    {
        byte[] uid = Guid.NewGuid().ToByteArray();
        byte[] bindDate = BitConverter.GetBytes(DateTime.Now.Ticks);
        byte[] sequencialGuid = new byte[uid.Length + 1];

        sequencialGuid[0] = uid[0];
        sequencialGuid[1] = uid[1];
        sequencialGuid[2] = uid[2];
        sequencialGuid[3] = uid[3];
        sequencialGuid[4] = uid[4];
        sequencialGuid[5] = uid[5];
        sequencialGuid[6] = uid[6];

        sequencialGuid[7] = (byte)(0xc0 | (0xf & uid[7]));
        sequencialGuid[8] =  bindDate[0];
        sequencialGuid[9] =  bindDate[1];
        sequencialGuid[10] = bindDate[2];
        sequencialGuid[11] = bindDate[3];
        sequencialGuid[12] = bindDate[4];
        sequencialGuid[13] = bindDate[5];
        sequencialGuid[14] = bindDate[6];
        sequencialGuid[15] = bindDate[7];

        return new Guid(sequencialGuid);
    }
}