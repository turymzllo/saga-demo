#this is a file with recommended variable names
prefix          = "test"
environment     = "dev"
location        = "brazilsouth"
partition_count = "2"
#failover location MUST be different than location, if same Terraform won't be able to create a Cosmos DB instance
failover_location    = "eastus"
storage_account_name = "strgfunctiondemo"
azure_function_app   = "functions-demo"
