W App.config w sekcji connectionString zmienić Data Source 
na własny server SQL którego chcemy użyć np.:
<connectionStrings>
	<add 
	name="MapDemoDb" 
	connectionString="Data Source=[MójServerSql];Initial Catalog=MapDemo;Integrated Security=True" 
	providerName="System.Data.SqlClient" />
</connectionStrings>

Najlepiej przeglądać po kolei elementy mające w nazwie Weapon, ponieważ pozostałe są kopią 
tylko dla innego zbioru danych.