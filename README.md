# DefaultParameterSample

デフォルト引数のバージョニング問題のサンプルです。ついでにconstのほうも。

## 確認方法(Windows + Visual Studio)

1. ソリューションをクローンしたら一度ビルドしてください。
2. コマンドラインで`\DefaultParameterSample.Console`に移動し、`dotnet publish -c Release -r win-x64`を実行してください。
3. `\DefaultParameterSample.Console\bin\Release\netcoreapp2.1\win-x64\`に実行可能な.exeファイルや.dllファイルが作成されているはずです。
4. 試しに`DefaultParameterSample.Console.exe`を実行してみましょう。
5. `\DefaultParameterSample.Core\Sample.cs`の`ConstString = "const_string: 1"`を他の値に変えてみましょう。
6. `DefaultParameterSample.Core`プロジェクトのみをReleaseモードでビルドしてください。
7. `\DefaultParameterSample.Core\bin\Release\netstandard2.0\`に生成されているファイルを`\DefaultParameterSample.Console\bin\Release\netcoreapp2.1\win-x64\`にコピー&置き換えしてください。
8. もう一度`DefaultParameterSample.Console.exe`を実行してみましょう。おそらく表示される内容が一部異なっているでしょう。