# OrchardSkills.OrchardCore.BulmaDarkTheme

Orchard Skills Bulma Dark Theme

# Note

Added the Bulma CSS with Webpack build to Visual Studio

Important! Neet to:

1. First Rebuild Solution without running.
2. Then Run.

There is a bizare bug in Visual Studio that you can't build and run at the same time on the first build. 
This issue only occurs the first time you build and run. 

# Manual Build for Bulma CSS with Webpack

Go to the directory: .\OrchardSkills.OrchardCore.BulmaDarkTheme


Building Bulma CSS with Webpack

# Building Bulma CSS with Webpack

## Install Packages

Use the following command:

### NPM

```
npm install
```

### Yarn

```
yarn install
```

## Development

A developer can build, debug and display the CSS and HTML using the development build and the Webpack server.
Use the following command:

### NPM

```
npm start
```

### Yarn

```
yarn start
```

## Production

In order to use the Bulma Dark Theme CSS a production build needs to be executed.
Use the following command:

### NPM

```
npm run deploy
```

### Yarn

```
yarn deploy
```

## Source Code

All the source code for the fonts, icons, images, styles, javascript and html are located in the ./src folder.

## Distrubution Code

After the production build, the files will be located in the ./wwwroot/dist folder
