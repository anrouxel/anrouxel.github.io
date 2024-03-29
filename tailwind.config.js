/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "**/*.razor",
    "**/*.cshtml",
    "**/*.html",
    "**/*.cs",
  ],
  theme: {
    fontFamily: {
      'sans': ['NotoSans', 'Inter', 'Ubuntu', 'sans-serif'],
      'serif': ['NotoSerif', 'Ubuntu', 'serif'],
      'mono': ['NotoSansMono', 'Ubuntu Mono', 'monospace'],
      'Inter': 'Inter',
      'InterVariable': 'InterVariable',
      'Metropolis': 'Metropolis',
      'ZillaSlab': 'ZillaSlab',
      'NotoColorEmoji': 'NotoColorEmoji',
      'NotoEmoji': 'NotoEmoji',
      'NotoEmojiVariable': 'NotoEmojiVariable',
      'NotoMusic': 'NotoMusic',
      'NotoSans': 'NotoSans',
      'NotoSansVariable': 'NotoSansVariable',
      'NotoSerif': 'NotoSerif',
      'NotoSerifVariable': 'NotoSerifVariable',
      'NotoSansMono': 'NotoSansMono',
      'NotoSansMonoVariable': 'NotoSansMonoVariable',
      'Ubuntu': 'Ubuntu',
      'UbuntuMono': 'UbuntuMono',
    },
    extend: {
      colors: {
        "EUAccentBlue": {
          100: "#00e9ff",
          30: "#b3f8ff",
        },
        "EUYellow": {
          140: "#997a00",
          130: "#b38f00",
          120: "#cca300",
          110: "#e6b800",
          100: "#fc0",
          80: "#ffd633",
          60: "#ffe066",
          40: "#ffeb99",
          20: "#fff5cc",
          10: "#fffae6",
          5: "#fffcf2",
        },
        "EURed": {
          140: "#8f0029",
          130: "#a70030",
          120: "#bf0036",
          110: "#d7003d",
          100: "#ef0044",
          80: "#f23369",
          60: "#f5668f",
          40: "#f999b4",
          20: "#fcccda",
          10: "#fde6ec",
          5: "#fef2f5",
        },
        "EUPurple": {
          140: "#31087b",
          130: "#390990",
          120: "#410aa4",
          110: "#490cb9",
          100: "#510dcd",
          80: "#743dd7",
          60: "#976ee1",
          40: "#bf9af1",
          20: "#dccff5",
          10: "#eee7fa",
          5: "#f6f3fc",
        },
        "EUOrange": {
          140: "#993b00",
          130: "#b34500",
          120: "#cc4e00",
          110: "#e65800",
          100: "#ff6200",
          80: "#ff8133",
          60: "#ff914d",
          40: "#ffb180",
          20: "#ffd0b3",
          10: "#ffefe6",
          5: "#fff7f2",
        },
        "EUGrey": {
          140: "#171a22",
          130: "#1b1e27",
          120: "#1e222d",
          110: "#222732",
          100: "#262b38",
          80: "#515560",
          60: "#7d8088",
          40: "#a8aaaf",
          20: "#d4d5d7",
          10: "#e9eaeb",
          5: "#f4f5f5",
          3: "#f9f9f9",
        },
        "EUGreen": {
          140: "#007957",
          130: "#008d66",
          120: "#00a174",
          110: "#00b583",
          100: "#00c991",
          80: "#33d4a7",
          60: "#66dfbd",
          40: "#99e9d3",
          20: "#ccf4e9",
          10: "#e6faf4",
          5: "#f2fcf9",
        },
        "EUBlue": {
          140: "#082b7a",
          130: "#0a328e",
          120: "#0b39a2",
          110: "#0d40b7",
          100: "#0e47cb",
          80: "#3e6cd5",
          60: "#6e91e0",
          40: "#9fb5ea",
          20: "#cfdaf5",
          10: "#e7edfa",
          5: "#f3f6fc",
        },
        "EUWhite": {
          100: "#ffffff",
        },
        "EUBlack": {
          100: "#000000",
        },
      },
      keyframes: {
        splash_in: {
          '0%': { opacity: 0 },
          '100%': { opacity: 1 },
        },
      },
      animation: {
        splash_in: 'splash_in 0.25s linear forwards',
      },
    },
  },
  plugins: [],
}

