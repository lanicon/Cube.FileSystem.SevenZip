CubeICE ユーザーマニュアル
====

Copyright © 2010 CubeSoft, Inc.  
support@cube-soft.jp  
https://www.cube-soft.jp/cubeice/

## 概要

![CubeICE の概要](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/Main.01.ja.png?raw=true)

CubeICE には、ファイルやフォルダーの圧縮・解凍（展開）処理を実際に行う **CubeICE** と、
圧縮・解凍（展開）処理に関する各種設定を変更する **CubeICE 設定** の 2 種類のアプリケーションが存在します。

## 圧縮

### コンテキストメニューから選択

圧縮したいファイルやフォルダーを選択し、右クリックで表示されるコンテキストメニューから **圧縮** を選択します。
サブメニューに圧縮形式の一覧が表示されますので、使用したい圧縮形式を選択します。

![圧縮メニュー](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/Main.02.ja.png?raw=true)

サブメニューで **詳細設定** を選択した場合、上記のようなダイアログが表示されます。
必要な設定を行った後、OK ボタンをクリックして下さい。
尚、**圧縮レベル** や **圧縮メソッド** は、作成される圧縮ファイルのファイルサイズに影響します。
また、CubeICE の圧縮機能は、マルチコア・プロセッサに対応しています。
ご利用のパソコンの CPU がマルチコアの場合は、**CPU スレッド数** で使用するコア数を設定できます。

### ショートカットへドラッグ&amp;ドロップ

![ショートカットへドラッグ&amp;ドロップ](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/Main.03.ja.png?raw=true)

圧縮ファイルを作成する別の方法として、ファイルやフォルダーを選択して **CubeICE 圧縮** ショートカットにドラッグ&amp;ドロップする方法があります。
この方法で圧縮ファイルを作成した場合、初期設定では Zip ファイルが作成されます。
ドラッグ&amp;ドロップしたときに作成される圧縮ファイルの圧縮形式を変更したい場合、**CubeICE 設定** で設定を変更して下さい。

### パスワードの設定

![パスワードの設定](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/Main.04.ja.png?raw=true)

右クリックで表示されるコンテキストメニューから **Zip（パスワード）** を選択、
または圧縮形式を **Zip（パスワード）** に設定している **CubeICE 圧縮** ショートカットにファイルやフォルダをドラッグ&amp;ドロップした場合、
上記のようにパスワードの入力を求められます。
ここで入力した文字列が、作成される圧縮ファイルを解凍（展開）する際のパスワードに設定されます。

## 解凍（展開）

### 関連付けられたファイルをダブルクリック

CubeICE に関連付けされた圧縮ファイルをダブルクリックする事で解凍（展開）が始まります。
初期設定で関連付けられている圧縮形式は、zip, 7z, lzh, rar, tar, gz (tgz),　bz2 (tbz), xz (txz) の 8 種類です。
ファイルの関連付けは **CubeICE 設定** で変更する事ができます。

### コンテキストメニューから選択

![解凍メニュー](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/Main.05.ja.png?raw=true)

エクスプローラー等で圧縮ファイルを右クリックすると **解凍** と言うメニューが表示されます。
この「解凍」メニューをクリックする事によっても解凍が始まります。

### ショートカットへのドラッグ&amp;ドロップ

![ショートカットへドラッグ&amp;ドロップ](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/Main.06.ja.png?raw=true)

CubeICE で圧縮ファイルを解凍（展開）する 3つめの方法は、圧縮ファイルを **CubeICE 解凍** にドラッグ&amp;ドロップする方法です。

### 上書きの確認

![上書きの確認](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/Main.07.ja.png?raw=true)

CubeICE で圧縮ファイルを解凍（展開）時、保存先に同名のファイルが存在すると上記のような確認ダイアログが表示されます。

この時、**すべてはい**、 **すべてリネーム**、**すべていいえ** を選択すると、これ以降、
同名のファイルが存在する際に確認なしに選択した処理（上書き/リネーム/破棄）を実行します。
また、**キャンセル** をクリックすると直ちに解凍（展開）を中止します。
**すべてリネーム** をクリックした場合は、元のファイル名が Test.txt であれば Test (2).txt のように
CubeICE が⾃動的に新しいファイル名に変更します。

### パスワードの入力

![パスワードの入力](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/Main.08.ja.png?raw=true)

解凍（展開）しようとした圧縮ファイルにパスワードが設定されている場合、パスワードを⼊⼒するダイアログが表示されます。

## ファイル一覧の表示

![ファイル一覧の表示](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/Main.09.ja.png?raw=true)

エクスプローラー等で CubeICE に関連付けられている圧縮ファイルにマウス・カーソルをあわせると、
ツールチップにその圧縮ファイルのファイル一覧が表示されます。

初期設定では該当の圧縮ファイルに 5 個以上ファイルが存在する場合、6 個目以降のファイルのファイル名表示は省略されます。
表示件数については、「CubeICE 設定」で変更する事ができます。

## 設定

### 一般

![メニュー等に関する設定](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/Settings.01.ja.png?raw=true)

##### ファイルの関連付け

ファイルをダブルクリックした際に CubeICE で解凍（展開）するファイルの種類を選択します。
関連付け可能なファイル形式は、zip, lzh, rar, 7z, iso, tar, gz, tgz, bz2, tbz, xz, txz,
arj, cab, chm, cpio, deb, dmb, hfs, jar, nupkg, rpm, vhd, vmdk, wim, xar, z の 27 種類です。

##### コンテキストメニュー

エクスプローラー等でファイルやフォルダーを右クリックした際に表示するコンテキストメニューを選択します。
それぞれの項目について、サブメニューも選択できます。

##### デスクトップに作成するショートカット

**圧縮**、**解凍** はファイルやフォルダーをドラッグ&amp;ドロップする形で CubeICE を実⾏するためのショートカットを作成します。
**圧縮** については、ドラッグ&amp;ドロップしたときに作成される圧縮形式も設定する事ができます。

### 圧縮

![圧縮に関する設定](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/Settings.02.ja.png?raw=true)

##### 保存場所

CubeICE で解凍（展開）した時、作成された圧縮ファイルを保存する場所を指定します。
指定できる場所は、以下の 3 通りです。

* **指定したフォルダ**  
  常にユーザが指定したフォルダーに圧縮ファイルを作成します。
  尚、**指定したフォルダ** をチェックしただけ（フォルダーの指定なし）の場合、デスクトップに圧縮ファイルを作成します。
* **元のファイルと同じフォルダ**  
  圧縮対象となるファイルやフォルダーと同じフォルダに圧縮ファイルも作成します。
* **実⾏時に指定する**  
  実⾏時に以下のようなダイアログが表示されます。  
  ![名前を付けて保存](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/Settings.06.ja.png?raw=true)

##### オプション

圧縮で設定可能なオプションは以下の通りです。

* **ファイルのフィルタリングを⾏う**  
  圧縮ファイルに特定の条件に合致する名前のファイルを含めないようにします。
  圧縮ファイルに含めないファイルやフォルダー名は **詳細** タブで設定可能です。
* **ファイル名を UTF-8 に変換する**  
  圧縮ファイルに含まれるファイル名等の情報を UTF-8 で記録します。
  このオプションは Windows で作成した圧縮ファイルを Mac 等で解凍する際に有効です。
  ただし、このオプションを有効にして作成した圧縮ファイルを別の Windows 端末で解凍する場合、その端末にも CubeICE を始めとした UTF-8 形式の圧縮ファイルを正常に解凍できるソフトウェアがインストールされている必要があります。
* **同名の圧縮ファイルが存在する時にダイアログを表示する**  
  保存先として指定したパスに同名の圧縮ファイルが存在する場合、確認のためのダイアログを表示します。
  このオプションが無効の場合、強制的に上書き保存されます。
* **圧縮後に保存先フォルダを開く**  
  圧縮処理が終了した後に、作成された圧縮ファイルが保存されているフォルダを⾃動的に開きます。
  この設定には、**デスクトップの場合は開かない** ように設定できるサブ項目が存在します。

### 解凍（展開）

![解凍（展開）に関する設定](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/Settings.03.ja.png?raw=true)

##### 保存場所

CubeICE で圧縮ファイルを解凍（展開）した時に、作成されたファイルやフォルダーを保存する場所を指定します。
指定できる場所は、以下の 3 通りです。

* **指定したフォルダ**  
  常にユーザが指定したフォルダーに圧縮ファイルを解凍します。
  **指定したフォルダ** をチェックしただけ（フォルダの指定なし）の場合、デスクトップに圧縮ファイルを解凍します。
* **元のファイルと同じフォルダ**  
  圧縮ファイルと同じフォルダに解凍します。
* **実⾏時に指定する**  
  実⾏時に保存場所を決定するためのダイアログが表示されます。

##### オプション

解凍（展開）で設定可能なオプションは以下の通りです。

* **複数の圧縮ファイルを同時に解凍する**  
  このオプションが有効の場合、複数の圧縮ファイルを選択して「解凍」が実行された時に指定されたファイルの数だけプロセスが起動し、全ての解凍処理が同時に実行されます。無効の場合、1 ファイルずつ順番に解凍処理が実行されます。
* **フォルダを自動的に作成する**  
  解凍する際に、元の圧縮ファイル名のフォルダを⾃動的に作成し、そのフォルダの中に解凍したファイル、フォルダーを保存します。
  この設定には、指定された圧縮ファイルが単一のフォルダに全てのファイルが格納されている場合、フォルダを作成しないようにするサブ項目が存在します。
* **ファイルのフィルタリングを⾏う**  
  解凍する際に、特定の条件に合致する名前のファイルを保存しないようにします。
  保存しない名前のファイルの設定は、**詳細** タブで設定可能です。
* **圧縮後に保存先フォルダを開く**  
  解凍処理が終了した後に、保存フォルダを⾃動的に開きます。
  この設定には、**デスクトップの場合は開かない** ように設定できるサブ項目が存在します。
* **解凍後に元のファイルを削除する**  
  解凍処理が終了した後に、圧縮ファイルを削除します。
  ただし、このオプションが有効な場合でも何らかのエラーが発生した時やキャンセルボタンがクリックされた時には削除されません。

### 詳細

![その他の設定](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/Settings.04.ja.png?raw=true)

##### フィルタリング

**圧縮**、**解凍** タブの **オプション** で **ファイルのフィルタリングを⾏う** を有効にした時に、
実際にフィルタリング（除外）するファイル名を記述します。
フィルタリングするファイル名は 1 ⾏に１つずつ記述します。

初期設定では、システムが⾃動的に生成する desktop.ini, Thumbs.db, .DS_Store, _MACOSX の
4 種類のファイルをフィルタリング対象に設定しています。

##### その他

その他の項目で設定可能なオプションは以下の通りです。

* **圧縮ファイルのツールチップにファイル一覧を表示する**  
  エクスプローラーなどで、CubeICE に関連付けられている圧縮ファイルにマウス・カーソルをあわせると、
  ツールチップにその圧縮ファイルのファイル一覧が表示されます。
* **エラーレポートを表示する**  
  CubeICE で圧縮・解凍（展開）を⾏っている時に何らかのエラーが発生した場合、エラー内容が表示されます。
* **コンピュータ起動時にアップデートを確認する**  
  CubeICE がバージョンアップした時に、タスクトレイに通知されます。

### バージョン情報

![バージョン情報](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/Settings.05.ja.png?raw=true)

CubeICE のバージョン情報が表示されます。
CubeICE には 32bit 版と 64bit 版が存在しますが、どちらを使用しているのかもここで判別できます。

## CubeICE のアンインストール

CubeICE をアンインストールするには、まず、コントロールパネルのプログラムのアンインストール
または、設定のアプリと機能（Windows 8 以降）を選択します。そして、表示される画面で
CubeICE のアイコンを選択してアンインストールの項目を実行して下さい。

![アンインストール（コントロールパネル）](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/UnInstall.01.ja.png?raw=true)
![アンインストール（設定）](https://github.com/cube-soft/Cube.FileSystem.SevenZip/blob/master/Applications/Ice/Assets/UnInstall.02.ja.png?raw=true)

## CubeICE で問題が発生した場合

CubeICE は、以下のフォルダに実行ログを出力しています（%UserName% は、ログオン中のユーザ名に置換）。  
```C:\Users\%UserName%\AppData\Local\CubeSoft\CubeIce\Log```  
問題が発生した時は、これらのログを添付して support@cube-soft.jp までご連絡をお願いいたします。
