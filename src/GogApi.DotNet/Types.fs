namespace GogApi.DotNet.FSharp

open System

/// <summary>
/// Contains all basic types which are needed in the whole domain
/// </summary>
module Types =
    /// <summary>
    /// Data which is needed to authenticate for the API
    /// </summary>
    type Authentication =
        { accessToken: string
          refreshToken: string
          accessExpires: DateTimeOffset }

    type GameId = GameId of uint32

    type UserId = UserId of uint64

    type UserName = UserName of string

    type DownLink = DownLink of string

    type FriendInfo =
        { username: UserName
          userSince: int
          galaxyId: string
          avatar: string }

    type Currency =
        { code: string
          symbol: string }

    type DownloadOSInfo =
        { date: string
          downloaderUrl: string option
          manualUrl: string
          name: string
          size: string // TODO: parse this somehow in a number? In additional field?
          version: string option }

    type Download =
        { linux: DownloadOSInfo list
          mac: DownloadOSInfo list
          windows: DownloadOSInfo list }

    type Language =
        { code: string
          name: string }

    type GameExtra =
        { manualUrl: string
          downloaderUrl: string option
          name: string
          ``type``: string // TODO: Is it possible to match this to a DU?
          info: int
          size: string } // TODO: parse this somehow in a number? In additional field?

    type ProductInfo =
        { id: int
          title: string }

    type File =
        { id: int
          size: uint32
          downlink: DownLink }

    type BonusContent =
        { id: int
          name: string
          ``type``: string
          count: int
          total_size: uint32
          files: File list }
