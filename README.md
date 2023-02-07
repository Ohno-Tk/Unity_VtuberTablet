# Unity_VtuberTablet
マウス座標を取得してVtuberの手を動かす

<!-- repo url. -->
[Releases]: https://img.shields.io/github/v/release/Ohno-Tk/Unity_VtuberTablet?logo=github
[Downloads]: https://img.shields.io/github/downloads/Ohno-Tk/Unity_VtuberTablet/total?logo=github
[Stars]: https://img.shields.io/github/stars/Ohno-Tk/Unity_VtuberTablet?style=social

<!-- development tool url. -->
[License]: https://img.shields.io/badge/license-MIT-blue.svg
[Unity]: https://img.shields.io/badge/Unity-2022.1.10f1-000000.svg?logo=unity&style=flat
[C#]: https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white&style=flat
[VSCode-image]: https://img.shields.io/badge/-Visual%20studio%20code-007ACC.svg?logo=visualstudiocode&style=flat

<!-- badge. -->
<div align="center">

  <!-- repo info -->
  [![License]](/.github/LICENSE) [![Releases]](https://github.com/Ohno-Tk/Unity_VtuberTablet/releases) ![Downloads] ![Stars]

  <!-- development tool -->
  ![Unity] ![C#] ![VSCode-image]
</div>

## Table of Contents(目次)
- Users(ユーザー向け)
  - [Screenshot](#screenshot)
  - [Features(セールスポイントなど)](#features)
  - [Getting Started (入門ガイド)](https://github.com/Ohno-Tk/OBS_Counter/wiki/Users_Getting-Started-(%E5%85%A5%E9%96%80%E3%82%AC%E3%82%A4%E3%83%89))
  - [Release Notes (リリースノート)](#release-notes)
- Developer(開発者向け)
  - [Architecture(設計資料)](#architecture)
  - [Coding Rule (コーディング規約)](#coding-rule)
  - [Development Process (開発プロセス)](#development-process)
    - [Commit Message Title Rule (コミットメッセージ規約)](#commit-message-title-rule)
    - [Pull Request(PRの作成方法)](#pull-request)
    - [Issue(チケットの起票方法)](#issue)
- [License(ライセンス)](#license)

## Screenshot
obsで表示できるカウンター
<div align="center">
  
</div>

## Features
- リッチな配信画面になる
- 手元を映さなくて良くなる。

## Release Notes

## Coding Rule
- [C# のコーディング規則](https://learn.microsoft.com/ja-jp/dotnet/csharp/fundamentals/coding-style/coding-conventions)

## Commit Message Title Rule
```
                        commit title
        commit type         /
                \           |
                 feat: add template url parameter to events
```
`commit type` としては次のようなものがあります。

- feat
    - 新しい機能など。
    - 更新履歴に載るような新しいページを追加。
- fix
    - 意味が変わる修正。
    - 更新履歴に載るような修正。
- docs
    - 基本的には使わない。
    - README.mdやCONTRIBUTING.mdや本体のプロジェクト全体のドキュメントについて。
- refactor
    - 意味が変わらない修正。
    - 更新履歴に載らないような修正。
- style
    - スペースやインデントの調整。
    - Lintエラーの修正など。
- perf
    - パフォーマンス改善。
- test
    - テストに関して。
- chore
    - その他。
    - typoの修正など。

`commit type`は、迷ったらとりあえず`chore`と書きます。
`scope`も省略して問題ないので以下のような形でも問題ありません。

```
chore: コミットメッセージ
```

## Development Process
### Pull Request
Pull Requestはいつでも歓迎しています。

1. まず Issue を作る。
1. Issue に対応したブランチを作る。
1. 作ったブランチからマージしたいブランチへ Pull Request を送る。
1. Pull Request をレビューする。
1. 修正点があれば修正する。
1. マージする。

### Issue
- 質問 => [こちらから質問できます](https://github.com/Ohno-Tk/OBS_Counter/issues/new?template=question.md)
- エラーや問題の報告 => [こちらからバグ報告できます。](https://github.com/Ohno-Tk/OBS_Counter/issues/new?template=bug_report.md)
- 提案 => [こちらから提案できます。](https://github.com/Ohno-Tk/OBS_Counter/issues/new?template=feature_request.md)

[その他のIssue](https://github.com/Ohno-Tk/OBS_Counter/issues/new?template=other.md)も歓迎しています。

## License
Released 2023 by Ohno-Tk
