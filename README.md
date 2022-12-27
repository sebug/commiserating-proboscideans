# Commiserating Proboscideans
Giving the Mastodon APIs a first go, trying to filter for toots from professionals about their work setup.

## Set up the app
On your Mastodon instance, add an app: https://yourmas.to/settings/applications/new .

You only need read permissions, it's perfect!

Save.

Now go to your GitHub codespaces secrets and add the three environment variables

COMMISERATOR_CLIENTKEY
COMMISERATOR_CLIENTSECRET
COMMISERATOR_ACCESSTOKEN

with the secrets of your app. You can check that your codespaces can access the variables by

    echo $COMMISERATOR_CLIENTKEY
