W App.config w sekcji connectionString zmienić Data Source 
na własny server SQL którego chcemy użyć np.:
<connectionStrings>
	<add 
	name="MapDemoDb" 
	connectionString="Data Source=[MójServerSql];Initial Catalog=MapDemo;Integrated Security=True" 
	providerName="System.Data.SqlClient" />
</connectionStrings>

Najlepiej przeglądać pokolei elementy mające w nazwie Weapon, ponieważ reszta powstawała 
na ich podstawie i mogą się tam pojawić jakieś braki lub niedorobienia.