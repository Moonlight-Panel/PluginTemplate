/** @type {import('tailwindcss').Config} */
module.exports = {
    corePlugins: {
        preflight: false,
    },
    content: [
        '../**/*.razor',
        'mappings/*.map'
    ],
    theme: {
        extend: {
            fontFamily: {
                inter: ['Inter', 'sans-serif'],
                scp: ['Source Code Pro', 'mono'],
            },
            colors: {
                primary: {
                    50: '#eef2ff',
                    100: '#e0e7ff',
                    200: '#c7d2fe',
                    300: '#a5b4fc',
                    400: '#818cf8',
                    500: '#6366f1',
                    600: '#4f46e5',
                    700: '#4338ca',
                    800: '#3730a3',
                    900: '#312e81',
                    950: '#1e1b4b'
                },
                secondary: {
                    100: '#F9F9F9',
                    200: '#F1F1F2',
                    300: '#DBDFE9',
                    400: '#B5B5C3',
                    500: '#99A1B7',
                    600: '#707993',
                    700: '#444e6b',
                    750: '#293249',
                    800: '#1c2438',
                    900: '#111721',
                    950: '#0e121c',
                },
                tertiary: {
                    50: '#f5f3ff',
                    100: '#ede9fe',
                    200: '#ddd6fe',
                    300: '#c4b5fd',
                    400: '#a78bfa',
                    500: '#8b5cf6',
                    600: '#7c3aed',
                    700: '#6d28d9',
                    800: '#5b21b6',
                    900: '#4c1d95',
                    950: '#2e1065'
                },
                warning: {
                    50: '#fefce8',
                    100: '#fef9c3',
                    200: '#fef08a',
                    300: '#fde047',
                    400: '#facc15',
                    500: '#eab308',
                    600: '#ca8a04',
                    700: '#a16207',
                    800: '#854d0e',
                    900: '#713f12',
                    950: '#422006'
                },
                danger: {
                    50: '#fef2f2',
                    100: '#fee2e2',
                    200: '#fecaca',
                    300: '#fca5a5',
                    400: '#f87171',
                    500: '#ef4444',
                    600: '#dc2626',
                    700: '#b91c1c',
                    800: '#991b1b',
                    900: '#7f1d1d',
                    950: '#450a0a'
                },
                success: {
                    50: '#f0fdf4',
                    100: '#dcfce7',
                    200: '#bbf7d0',
                    300: '#86efac',
                    400: '#4ade80',
                    500: '#22c55e',
                    600: '#16a34a',
                    700: '#15803d',
                    800: '#166534',
                    900: '#14532d',
                    950: '#052e16'
                },
                info: {
                    50: '#eff6ff',
                    100: '#dbeafe',
                    200: '#bfdbfe',
                    300: '#93c5fd',
                    400: '#60a5fa',
                    500: '#3b82f6',
                    600: '#2563eb',
                    700: '#1d4ed8',
                    800: '#1e40af',
                    900: '#1e3a8a',
                    950: '#172554'
                },
                gray: {
                    100: '#F9F9F9',
                    200: '#F1F1F2',
                    300: '#DBDFE9',
                    400: '#B5B5C3',
                    500: '#99A1B7',
                    600: '#707993',
                    700: '#444e6b',
                    750: '#293249',
                    800: '#1c2438',
                    900: '#111721',
                    950: '#0e121c',
                }
            },
            textColor:{
                diffcolor: 'rgb(var(--color-diffcolor, var(--color-light)))'
            },
            animation: {
                'shimmer': 'shimmer 2s linear infinite',
            }
        },
    }
}