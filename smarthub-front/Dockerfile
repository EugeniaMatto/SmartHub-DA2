# Usar la imagen oficial de Node.js para construir la aplicación Angular
FROM node:16 AS build
WORKDIR /app
COPY . ./
RUN npm install
RUN npm run build --prod

# Usar una imagen ligera de Nginx para servir la aplicación Angular
FROM nginx:alpine
COPY --from=build /app/dist/mi-app-angular /usr/share/nginx/html
