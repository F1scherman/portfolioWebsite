/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["**/*.razor", "**/*.cshtml", "**/*.html"],
  theme: {
      extend: {},
  },
  plugins: [
      require("@catppuccin/tailwindcss")({
          defaultFlavour: "macchiato",
          prefix: "cat",
      })
  ],
}

