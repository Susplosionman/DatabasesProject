# This file needs to be altered to work for our database


Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "CIS560"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

<#
   If on your local machine, you can drop and re-create the database.
#>
& "./DropDatabase.ps1" -Database $Database
& "./CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
#Write-Host "Dropping tables..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Schemas\Movie.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\Movie.Director.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\Movie.Actor.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\Movie.Movie.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\Movie.ActorMovies.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\Movie.User.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\Movie.Showing.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\Movie.Review.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\Movie.ShowingAttendance.sql"


#Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Procedures\Movie.CreateMovie.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Procedures\Movie.CreateDirector.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Procedures\Movie.RetrieveMovies.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Procedures\Movie.DeleteMovie.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Procedures\Movie.FetchDirector.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Procedures\Movie.CreateShowing.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Procedures\Movie.RetrieveShowingsForMovie.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Procedures\Movie.DeleteShowing.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Procedures\Movie.FetchDirectorByID.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Procedures\Movie.CreateReview.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Procedures\Movie.CreateUser.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Procedures\Movie.RetrieveAllUsers.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Procedures\Movie.CreateShowingAttendance.sql"
#Data doesnt need to be persistent between rebuilds
Write-Host "Inserting data..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Data\Person.AddressType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Data\Movie.SampleDataGoesHere.sql"

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
