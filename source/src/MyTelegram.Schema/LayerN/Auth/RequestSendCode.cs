﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Auth.LayerN;

///<summary>
/// Send the verification code for login
/// <para>Possible errors</para>
/// Code Type Description
/// 400 API_ID_INVALID API ID invalid.
/// 400 API_ID_PUBLISHED_FLOOD This API id was published somewhere, you can't use it now.
/// 500 AUTH_RESTART Restart the authorization process.
/// 400 PHONE_NUMBER_APP_SIGNUP_FORBIDDEN You can't sign up using this app.
/// 400 PHONE_NUMBER_BANNED The provided phone number is banned from telegram.
/// 400 PHONE_NUMBER_FLOOD You asked for the code too many times.
/// 406 PHONE_NUMBER_INVALID The phone number is invalid.
/// 406 PHONE_PASSWORD_FLOOD You have tried logging in too many times.
/// 400 PHONE_PASSWORD_PROTECTED This phone is password protected.
/// 400 SMS_CODE_CREATE_FAILED An error occurred while creating the SMS code.
/// See <a href="https://corefork.telegram.org/method/auth.sendCode" />
///</summary>
[TlObject(0x86aef0ec)]
public sealed class RequestSendCode : IRequest<MyTelegram.Schema.Auth.ISentCode>
{
    public uint ConstructorId => 0x86aef0ec;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool AllowFlashcall { get; set; }

    ///<summary>
    /// Phone number in international format
    ///</summary>
    public string PhoneNumber { get; set; }
    public bool? CurrentNumber { get; set; }

    ///<summary>
    /// Application identifier (see <a href="https://corefork.telegram.org/myapp">App configuration</a>)
    ///</summary>
    public int ApiId { get; set; }

    ///<summary>
    /// Application secret hash (see <a href="https://corefork.telegram.org/myapp">App configuration</a>)
    ///</summary>
    public string ApiHash { get; set; }

    public void ComputeFlag()
    {
        if (AllowFlashcall) { Flags[0] = true; }
        if (CurrentNumber !=null) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(PhoneNumber);
        if (Flags[0]) { writer.Write(CurrentNumber.Value); }
        writer.Write(ApiId);
        writer.Write(ApiHash);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { AllowFlashcall = true; }
        PhoneNumber = reader.ReadString();
        if (Flags[0]) { CurrentNumber = reader.Read(); }
        ApiId = reader.ReadInt32();
        ApiHash = reader.ReadString();
    }
}
