#version 330 core
out vec4 FragColor;

in vec2 TexCoords;
in vec3 Normal;
in vec3 FragPos;

uniform sampler2D texture_diffuse1;

void main()
{
    vec3 color = vec3(texture(texture_diffuse1, TexCoords));
    FragColor = vec4(color*0.7, 1.0);
}