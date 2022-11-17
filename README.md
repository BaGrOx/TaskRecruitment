# TaskRecruitment

## Technologie:
* Visual Studio 2022
* .NET
* WPF
* SQL Server 2019
* SS MS 2019
* NuGet - System.Data.SqlClient

## Uruchomienie 
Przed uruchomieniem programu należy wykonać na bazie danych skrypt zamieszczony w folderze bin\DevData.sql

## Opis
Aplikacja pozwala połączyć sie z bazą danych za pomocą Sql Server Authentication, za pomocą loginu i hasła, który należy wprowadzić.
Program posiada 3 przyciski, odpowiadające za następujące funkcje.

1. Testuj połączenie - pozwala sprawdzić czy wprowadzone login i hasło, uwierzytelniają dostęp do servera i bazy danych DevData.
2. Połącz - powoduje połączenie z serwerem i bazą danych
3. Załaduj dane - domyślnie jest niedostępne i odblokowuje się w momenecie poprawnego połaczenia z bazą danych. Odpowiada on za wykonanie zapytania na bazie danych i zwraca wartości do głównego grida.


## PS:
Jeśli program po pobraniu lub sklonowaniu nie będzie chciał się uruchomić należy wykonać następujące kroki: 
1. Skopiować ścieżkę pliku "TaskRecruitment.csproj".
2. Wejść w Eksplorator rozwiązań w Visual Studio.
3. Nacisnąć plik, który nie chce się załadować.
4. Następnie w Właściwościach tego pliku wkleić ścieżkę, skopiowaną w kroku 1.
5. Ponownie w Eksploratorze rozwiązań, nacisnąć prawym przyciskiem myszy na plik i załadować go ponownie.
6. Jeśli powyższe kroki nie zadziałają, dodatkowo usunąć plik .suo
