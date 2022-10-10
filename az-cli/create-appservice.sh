rnd=$1
grp=mvc-devops-$rnd
loc=westeurope
appPlan=devopsplan-$rnd
app=mvc-devops-skills-$rnd

az group create -n $grp -l $loc

az appservice plan create -n $appPlan -g $grp --sku FREE 

az webapp create -n $app -g $grp --plan $appPlan --runtime "DOTNET|6.0"
